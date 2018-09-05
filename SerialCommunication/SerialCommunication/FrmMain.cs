using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CommonMethod;
using LeafSoft.Lib;

namespace SerialCommunication
{
    public partial class FrmMain : Form
    {
        NetRs232 netRs232 = new NetRs232();

        private string _value = "";

        private UTF8Encoding _utf8 = new UTF8Encoding();

        private ASCIIEncoding _ascii = new ASCIIEncoding();

        #region 窗体构造函数
        public FrmMain()
        {
            InitializeComponent();

            this.Text = "超级串口通讯调试工具";
            this.StartPosition = FormStartPosition.CenterScreen;

            txtReceiveData.ScrollBars = ScrollBars.Vertical;
            //txtOriginalData.Text = "1 16 0 3 0 2 4 0 3 135 65 224 122";
            txtOriginalData.Text = "01 03 00 03 00 02";

            drpComList.Items.AddRange(SerialPort.GetPortNames());
            if (drpComList.Items.Count > 0)
            {
                drpComList.SelectedIndex = 0;
                btnCom.Enabled = true;
            }
            drpBaudRate.SelectedIndex = 5;
            drpParity.SelectedIndex = 0;
            drpDataBits.SelectedIndex = 0;
            drpStopBits.SelectedIndex = 0;

            cboDataType.SelectedIndex = 1;

            netRs232.DataReceived += NetRs232_DataReceived;
        }

        #endregion

        #region 接收数据事件
        private void NetRs232_DataReceived(byte[] receiveBytes)
        {
            txtReceiveData.BeginInvoke(new MethodInvoker(() =>
            {
                txtReceiveData.AppendText(CommonMethod.TypeConvert.BytesToString(receiveBytes));
                txtReceiveData.AppendText("\r\n");
                txtReceiveData.AppendText(new UTF8Encoding().GetString(receiveBytes).Replace("\r", "\r\n"));
                txtReceiveData.SelectionStart = txtReceiveData.TextLength;

                if (!chkOnlyShowValue.Checked)
                {
                    txtReceiveData.AppendText("Hex：" + CommonMethod.TypeConvert.BytesToHex(receiveBytes));
                    txtReceiveData.AppendText("\r\n");
                }


                try
                {
                    if (rbtnDingJian.Checked)
                    {
                        _value = _ascii.GetString(receiveBytes);
                    }
                    else if (rbtnWeight.Checked)
                    {
                        _value = _ascii.GetString(receiveBytes);
                        _value = _value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
                    }
                    else if (rbtnModbusRTU.Checked)
                    {
                        byte[] valueBytes = new byte[receiveBytes.Length - 3];
                        Array.Copy(receiveBytes, 3, valueBytes, 0, valueBytes.Length);
                        _value = CommonMethod.TypeConvert.AsciiBytesToValue(cboDataType.Text, valueBytes);
                    }
                }
                catch (Exception ex)
                {
                    txtReceiveData.AppendText(ex.Message);
                    txtReceiveData.AppendText("\r\n");
                }

                txtReceiveData.AppendText("值：" + _value.Replace("\r\n", ""));
                txtReceiveData.AppendText("\r\n");
            }));
        }
        #endregion

        #region 控件事件
        private void btnCom_Click(object sender, EventArgs e)
        {
            if (netRs232.serialPort.IsOpen)
            {
                netRs232.Close();

                btnCom.Text = "打开串口";
                picComStatus.Image = Properties.Resources.redlight;
            }
            else
            {
                bool ret = netRs232.Open(drpComList.Text, Convert.ToInt32(drpBaudRate.Text),
                    (Parity)Enum.Parse(typeof(Parity), drpParity.Text), Convert.ToInt32(drpDataBits.Text),
                    (StopBits)Enum.Parse(typeof(StopBits), drpStopBits.Text));

                if (ret)
                {
                    btnCom.Text = "关闭串口";
                    picComStatus.Image = Properties.Resources.greenlight;
                }
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            //CommonMethod.TypeConvert.st 

            netRs232.SendData(CommonMethod.TypeConvert.ByteStringToBytes(txtSendData.Text));
            //netRs232.SendData(new byte[] { 01, 03, 00, 03, 00, 02, 0x34, 0x0B });
            //netRs232.SendData(new byte[] { 01, 03, 00, 03, 00, 02, 0x34, 0x0B });

            return;
            //netRs232.SendData(CommonMethod.TypeConvert.ByteStringToBytes(txtSendData.Text));// new byte[] { 1, 16, 0, 3, 0, 2, 4, 0, 3, 135, 65, 224, 122 }

            Thread t = new Thread(() =>
            {
                while (true)
                {
                    if (netRs232.serialPort.IsOpen)
                    {
                        Console.WriteLine("True");

                        Thread.Sleep(50);
                        netRs232.SendData(CommonMethod.TypeConvert.ByteStringToBytes(txtSendData.Text));

                        //netRs232.SendData(new byte[] { 01, 03, 00, 03, 00, 02, 0x34, 0x0B });
                        //netRs232.SendData(new byte[] { 01, 03, 00, 01, 00, 01, 0x34, 0x0B });
                        //netRs232.SendData(new byte[] { 01, 03, 00, 02, 00, 01, 0x34, 0x0B });

                        //netRs232.SendData(new byte[] { 01, 03, 00, 03, 00, 01, 0x34, 0x0B});


                        //netRs232.SendData(new byte[] { 01, 03, 00, 03, 00, 02, 0x34, 0x0B });
                    }
                    else
                    {
                        Console.WriteLine("False");
                        //btnCom.PerformClick();
                        return;
                    }
                }
            });
            t.IsBackground = true;
            t.Start();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            List<string> lsDec = txtOriginalData.Text.Split(' ').ToList();
            ushort address = Convert.ToUInt16(lsDec[3]);
            //byte[] bytesaddress = BitConverter.GetBytes(address);
            if (address > 255)
            {
                lsDec[2] = ((byte)(address >> 8)).ToString();
                lsDec[3] = ((byte)(address)).ToString();
            }

            byte[] bytesCRC = BytesCheck.GetCRC16(TypeConvert.ByteStringToBytes(string.Join(" ", lsDec)), true);
            foreach (byte b in bytesCRC)
            {
                lsDec.Add(b.ToString());
            }

            txtSendData.Text = string.Join(" ", lsDec);
            Console.WriteLine(string.Join(" ", lsDec));
        }
        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {   

            byte[] bytes = new byte[]{ 8, 3, 6, 0, 254, 2, 121, 0, 0, 178, 144 };
           string str= TypeConvert.BytesToHex(bytes);
        }
    }
}

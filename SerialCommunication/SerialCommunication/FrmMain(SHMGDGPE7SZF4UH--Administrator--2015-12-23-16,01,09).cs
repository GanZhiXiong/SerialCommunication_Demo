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

        #region 地磅相关字段
        /// <summary>
        /// 接收的到字节数组解码为的字符串
        /// </summary>
        private string strAscii;

        /// <summary>
        /// 地磅重量
        /// </summary>
        private string weight;
        #endregion
        
        public FrmMain()
        {
            InitializeComponent();

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

            netRs232.DataReceived += netRs232_DataReceived;
        }

        void netRs232_DataReceived(byte[] obj)
        {
            //txtReceiveData.BeginInvoke(new MethodInvoker(() =>
            //{
            //    //txtReceiveData.AppendText(CommonMethod.TypeConvert.BytesToString(obj));
            //    //txtReceiveData.AppendText("\r\n");

            //    ////txtReceiveData.AppendText(new UTF8Encoding().GetString(obj).Replace("\r", "\r\n"));
            //    //txtReceiveData.SelectionStart = txtReceiveData.TextLength;


            //    //地磅ASCII显示
            //    //strAscii = new ASCIIEncoding().GetString(obj);
            //    //weight = strAscii.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries)[1];
            //    //txtReceiveData.AppendText(weight);
            //    //txtReceiveData.AppendText("\r\n");

            //    //读卡设备
            //    txtReceiveData.AppendText(CommonMethod.TypeConvert.BytesToString(obj));
            //    byte[] valueBytes = new byte[obj.Length - 3];
            //    Array.Copy(obj, 3, valueBytes, 0, valueBytes.Length);
            //    txtReceiveData.AppendText("\r\n");

            //    txtReceiveData.AppendText("值：" + CommonMethod.TypeConvert.AsciiBytesToValue(cboDataType.Text, valueBytes));
            //    txtReceiveData.AppendText("\r\n");
            //}));
        }

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

        protected override void WndProc(ref Message m)
        {
            Console.WriteLine(m.Msg.ToString());
            base.WndProc(ref m);
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
    }
}

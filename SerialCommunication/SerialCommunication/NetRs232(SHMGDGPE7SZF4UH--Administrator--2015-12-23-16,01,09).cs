using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerialCommunication
{
    public class NetRs232
    {
        public SerialPort serialPort;

        public NetRs232()
        {
            serialPort = new SerialPort();
            serialPort.DataReceived += serialPort_DataReceived;
        }

        /// <summary>
        /// 串口打开/关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public bool Open(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
        {
            if (serialPort.IsOpen == false)
            {
                serialPort.PortName = portName;
                serialPort.BaudRate = baudRate;
                serialPort.Parity = parity;
                serialPort.DataBits = dataBits;
                serialPort.StopBits = stopBits;

                try
                {
                    serialPort.Open();

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        ///串口
        /// </summary>
        public void Close()
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Close();
                    serialPort.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public event Action<byte[]> DataReceived;

        /// <summary>
        /// 输出数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                Thread.Sleep(50);
                byte[] reBytes = new byte[serialPort.BytesToRead];
                serialPort.Read(reBytes, 0, reBytes.Length);//读取数据

                DataReceived(reBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="data"></param>
        public bool SendData(byte[] data)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    serialPort.Write(data, 0, data.Length);//发送数据
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}

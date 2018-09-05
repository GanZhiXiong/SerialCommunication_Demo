using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommonMethod
{
    public class TypeConvert
    {
        /// <summary>
        /// 16进制数组转byte数组
        /// </summary>
        /// <param name="B"></param>
        /// <returns></returns>
        public static byte[] HexToBytes(byte[] B)
        {
            byte[] BToInt32 = new byte[B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                BToInt32[i] = (byte)Convert.ToInt32(B[i].ToString(), 16);
            }
            return BToInt32;
        }

        /// <summary>
        /// 字节数组转换为十六进制，返回空格分割的十六进制字符串
        /// </summary>
        /// <param name="data">字节数组</param>
        public static string BytesToHex(byte[] data)
        {
            //16进制显示
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("{0:x2}" + " ", data[i]);
            }
            return sb.ToString().ToUpper();
        }

        /// <summary>
        /// 字节数组转换为空格分割字节字符串
        /// </summary>
        /// <param name="data">字节数组</param>
        public static string BytesToString(byte[] data)
        {
            //16进制显示
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.AppendFormat("{0}" + " ", data[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 空格分割的十六进制字符串转换为字节数组
        /// </summary>
        /// <param name="shex"></param>
        /// <returns></returns>
        public static byte[] StringToBytes(string shex)
        {
            string[] ssArray = shex.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            List<byte> bytList = new List<byte>();
            foreach (var s in ssArray)
            {
                //将十六进制的字符串转换成数值
                bytList.Add(Convert.ToByte(s, 16));
            }
            //返回字节数组
            return bytList.ToArray();
        }

        /// <summary>
        /// 将按空格分隔的字符串（字节）转换为字节数组
        /// </summary>
        /// <param name="ByteString"></param>
        /// <returns></returns>
        public static byte[] ByteStringToBytes(string ByteString)
        {
            string[] strs = ByteString.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            byte[] bytes = new byte[strs.Length];

            //逐个字符串转换为字节
            for (int i = 0; i < strs.Length; i++)
            {
                bytes[i] = Convert.ToByte(strs[i]);
            }

            return bytes;
        }

        /// <summary>
        /// 将变量类型转换为发送Modbus格式数据类型
        /// </summary>
        /// <param name="variablesInfo"></param>
        /// <param name="slaveId"></param>
        /// <returns></returns>
        //public static ModbusDataFormt ConvertToModbusDataFormt(Model.VariablesInfo variablesInfo, string slaveId)
        //{
        //    return new ModbusDataFormt(variablesInfo.Name, variablesInfo.Address, variablesInfo.DataType, slaveId);
        //}

        #region 十进制字节数组转换为实际值
        /// <summary>
        /// 十进制字节数组转换为实际值
        /// </summary>
        /// <returns></returns>
        public static string AsciiBytesToValue(string dataType, byte[] oneVarBytes)
        {
            byte[] valueBytes;
            string value = "";
            if (dataType == "Boolean")
            {
                valueBytes = new byte[1];
                Array.Copy(oneVarBytes, 0, valueBytes, 0, 1);
           
                Array.Reverse(valueBytes);

                if (BitConverter.ToBoolean(valueBytes, 0))
                {
                    value = "1";
                }
                else
                {
                    value = "0";
                }
            }
            else if (dataType == "Word")//16位无符号整数
            {
                valueBytes = new byte[2];
                Array.Copy(oneVarBytes, 0, valueBytes, 0, 2);
        
                Array.Reverse(valueBytes);

                value = BitConverter.ToUInt16(valueBytes, 0).ToString();
            }
            else if (dataType == "DWord")//32位无符号整数
            {
                valueBytes = new byte[4];
                Array.Copy(oneVarBytes, 0, valueBytes, 0, 4);
          
                Array.Reverse(valueBytes);

                value = BitConverter.ToUInt32(valueBytes, 0).ToString();
            }
            else if (dataType == "Float")
            {
                valueBytes = new byte[4];
                Array.Copy(oneVarBytes, 0, valueBytes, 0, 4);
         
                Array.Reverse(valueBytes);

                value = BitConverter.ToSingle(valueBytes, 0).ToString();
            }
            else if (dataType == "Double")
            {
                valueBytes = new byte[8];

                Array.Copy(oneVarBytes, 0, valueBytes, 0, 8);
     
                Array.Reverse(valueBytes);

                value = BitConverter.ToDouble(valueBytes, 0).ToString();
            }

            return value;
        }
        #endregion
    }
}

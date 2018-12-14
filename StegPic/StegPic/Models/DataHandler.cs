using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StegPic.Models
{
    class DataHandler
    {
        public static string DataToBinary (string data)
        {
            string binaryString = "", tmp;
            for (int i = 0; i < data.Length; i++)
            {
                tmp = byte.Parse(data[i].ToString()).ToString();
                for (int j = 0; i < 8 - tmp.Length; i++)
                {
                    tmp = "0" + tmp;
                }
                binaryString += tmp;
            }
            return binaryString;
        }

        public static string BinaryToData (string binaryString)
        {
            string data = "", tmp = "";

            for (int i = 0; i < binaryString.Length; i += 8)
            {
                for (int j = 0; j < 8; j++)
                {
                    tmp += binaryString[j];
                }
                data += (char)Convert.ToByte(tmp, 2);
            }
            return data;
        }
    }
}

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
            int n;
            for (int i = 0; i < data.Length; i++)
            {
                //tmp = byte.Parse(data[i].ToString()).ToString();
                tmp = Convert.ToString(Convert.ToByte(data[i]), 2);
                n = tmp.Length;
                for (int j = 0; j < 8 - n; j++)
                {
                    tmp = "0" + tmp;
                }
                binaryString += tmp;
            }
            //correct
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

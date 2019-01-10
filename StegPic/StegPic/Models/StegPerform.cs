using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace StegPic.Models
{
    //The stage of decryption
    class StegPerform
    {
        public static Bitmap EmbedData (string data, Bitmap bmp,  string key)
        {
            key = key == "" ? key = "|3&  y/£&&#" : key;
            data = DataHandler.DataToBinary(data + key);
            bool embedDone = false;

            for(int heightIndex = 0; (heightIndex < bmp.Height && !embedDone); heightIndex++)
            {
                for (int widthIndex = 0; (widthIndex < bmp.Width && !embedDone); widthIndex++)
                {
                    Color pixel = bmp.GetPixel(widthIndex, heightIndex);
                    //REMEMBER: PIXELINDEX IS bmp.Width * heightIndex + widthIndex
                    int x = (heightIndex * bmp.Width + widthIndex) * 3;
                    if (x + 2 < data.Length)
                    {
                        bmp.SetPixel(widthIndex, heightIndex, Color.FromArgb(ConfigureColor(data[x], pixel.R), ConfigureColor(data[x + 1], pixel.G), ConfigureColor(data[x + 2], pixel.B)));
                    }
                    else
                    {
                        
                        switch (data.Length - x)
                        {
                            case 2:
                                bmp.SetPixel(widthIndex, heightIndex, Color.FromArgb(ConfigureColor(data[x], pixel.R), ConfigureColor(data[x + 1], pixel.G), pixel.B));
                                break;
                            case 1:
                                bmp.SetPixel(widthIndex, heightIndex, Color.FromArgb(ConfigureColor(data[x], pixel.R), pixel.G, pixel.B));
                                break;
                            case 0:
                                break;
                        }
                    }
                    
                }

            }
            return bmp;
        }
        //correct
        static byte ConfigureColor(char bit, byte colorValue)
        {

            string byteValue = Convert.ToString(colorValue, 2);
            int b = byteValue.Length;
            if (byteValue.Length != 8)
            {
                for (int i = 0; i < 8 - b; i++)
                {
                    byteValue = "0" + byteValue;
                }
            }
            byteValue = byteValue[7] == bit ? byteValue : byteValue.Replace(byteValue[7], bit);
            return Convert.ToByte(byteValue, 2);
        }



        public static string ExtractData (Bitmap bmp, string key)
        {
            key = key == "" ? key = "|3&  y/£&&#" : key;
            bool extractDone = false;
            string bitSeq = String.Empty, output = String.Empty;
            int colorIndex = 0;
            
            //int bitsConfigured = 0,
                //numberOfBits = bmp.Width * 3,
                //bytesConfigured = 0,
                //charsPerLine = bmp.Width - ((numberOfBits) % 8);
            for (int y = 0; y < bmp.Height && !extractDone; y++)
            {
                for (int x = 0; x < bmp.Width && !extractDone; x++)
                {
                    Color pixel = bmp.GetPixel(x, y);
                    for (int n = 0; n < 3; n++)
                    {
                        
                        switch (n)
                        {
                            case 0:
                                bitSeq += (pixel.R % 2).ToString();
                                break;
                            case 1:
                                bitSeq += (pixel.G % 2).ToString();
                                break;
                            case 2:
                                bitSeq += (pixel.B % 2).ToString();
                                break;
                        }
                        colorIndex++;
                        if (bitSeq.Length == 8)
                        {
                            output += (char)Convert.ToByte(bitSeq, 2);
                            extractDone = (char)Convert.ToByte(bitSeq, 2) == key[key.Length - 1] && CheckForKey(output, key) ? true: false;
                            bitSeq = String.Empty;
                        }
                    }
                }
            }
            return output.Remove(output.Length - key.Length);
        }

        public static bool CheckForKey(string message, string key)
        {
            bool isKey = false;
            if (message.Length > key.Length)
            {
                isKey = (message.Substring(message.Length - key.Length) == key);
            }
            return isKey;
        }
    }
}
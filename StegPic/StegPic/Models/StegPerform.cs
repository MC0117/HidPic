using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace StegPic.Models
{
    //The stage of decryption
    enum ExtractStage { }
    class StegPerform
    {
        static Bitmap EmbedData (string data, Bitmap bmp)
        {
            int bitsPerRow = bmp.Width * 3;
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

        static byte ConfigureColor(char bit, byte colorValue)
        {

            string byteValue = Convert.ToString(colorValue, 2);

            if (byteValue.Length != 8)
            {
                for (int i = 0; i < 8 - byteValue.Length; i++)
                {
                    byteValue = "0" + byteValue;
                }
            }
            byteValue = byteValue[7] == bit ? byteValue : byteValue.Replace(byteValue[7], bit);
            return Convert.ToByte(byteValue, 2);
        }

        static string ExtractData (Bitmap bmp)
        {
            bool extractDone = false;
            string s = "", seq = "|&)) % p0||", t = "";
            for (int heightIndex = 0; (heightIndex < bmp.Height && extractDone); heightIndex++)
            {
                for (int widthIndex = 0; (widthIndex < bmp.Width && extractDone); widthIndex++)
                {
                    Color pixel = bmp.GetPixel(widthIndex, heightIndex);
                    for (int bitIndex = 0; bitIndex < 3; bitIndex++)
                    {
                        if (bitIndex > 10)
                        {
                            if (s[bitIndex] == '|')
                            {
                                for (int i = 10; i > 0; i--)
                                {
                                    if(!(s[bitIndex - i] == seq[10 - i]))
                                    {
                                        t = seq[10 - i] + t;
                                        break;
                                    }
                                }
                            }

                        }
                    }
                }
            }
            return s;
        }

    }
}
//bmp.SetPixel(widthIndex, heightIndex, Color.FromArgb(ConfigureColor(data[bmp.Width*heightIndex + widthIndex], pixel.R), ConfigureColor(data[1], pixel.G), ConfigureColor(data[2], pixel.B)));
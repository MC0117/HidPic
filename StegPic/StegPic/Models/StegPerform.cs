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
                        //not correct byte is saved
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
            Convert.ToByte(byteValue, 2);
            return Convert.ToByte(byteValue, 2);
        }



        public static string ExtractData (Bitmap bmp, string key)
        {
            key = key == "" ? key = "|3&  y/£&&#" : key;
            bool extractDone = false;
            string binaryString = "", output = "";
            int bitsConfigured = 0,
                numberOfBits = bmp.Width * 3,
                bytesConfigured = 0,
                charsPerLine = bmp.Width - ((numberOfBits) % 8);

            for (int heightIndex = 0; (heightIndex < bmp.Height && !extractDone); heightIndex++)
            {
                for (int widthIndex = 0; !extractDone && widthIndex < bmp.Width; widthIndex++)
                {
                    Color pixel = bmp.GetPixel(widthIndex, heightIndex);
                    //checks for stop key
                    if (bitsConfigured > 8 && bytesConfigured != bitsConfigured / 8)
                    {
                        bytesConfigured = bitsConfigured / 8;
                        int n = bytesConfigured % 8, t = 0;

                        if (key[key.Length - 1] == (char)(Convert.ToByte(binaryString.Substring(bitsConfigured - (8 + n), 8), 2)))
                        {
                            for (int i = 0; i < key.Length - 1; i++)
                            {
                                if (key[key.Length - i + 1] == (char)(Convert.ToByte(binaryString.Substring(bitsConfigured - ((8 + n) + 8 * i), 8), 2)))
                                {
                                    t++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            extractDone = t == key.Length - 1 ? true : false;
                        }
                        else
                        {
                            output += Convert.ToByte(binaryString.Substring(bitsConfigured - (8 + n), 8), 2);
                        }
                    }
                    if (!extractDone)
                    {
                        string s1 = Convert.ToString(pixel.R, 2)[Convert.ToString(pixel.R).Length - 1].ToString(), 
                            s2 = Convert.ToString(pixel.G, 2)[Convert.ToString(pixel.G).Length - 1].ToString(), 
                            s3 = Convert.ToString(pixel.B, 2)[Convert.ToString(pixel.B).Length - 1].ToString();
                        // it will repeat itself due to the fact
                        binaryString += Convert.ToString(pixel.R, 2)[Convert.ToString(pixel.R).Length - 1].ToString();
                        binaryString += Convert.ToString(pixel.G, 2)[Convert.ToString(pixel.G).Length - 1].ToString();
                        binaryString += Convert.ToString(pixel.B, 2)[Convert.ToString(pixel.B).Length - 1].ToString();
                        bitsConfigured += 3;
                    }
                }
            }
                return output;
        }
    }
}

/*
    switch (bitsConfigured % 3)
                    {
                        case 0:
                            break;
                        case 1:
                            break;
                        case 2:
                            break;
                    }







bitPosition = 3 * (bmp.Width * heightIndex + widthIndex);
                    if (bitPosition > 10 && s[bitPosition] == key[0])
                    {
                        for (int i = key.Length; i >= 0; i--)
                        {
                            if (!(s[bitPosition - i] == key[key.Length - i]))
                            {
                                t++;
                            }
                        }
                    } 
*/
//bmp.SetPixel(widthIndex, heightIndex, Color.FromArgb(ConfigureColor(data[bmp.Width*heightIndex + widthIndex], pixel.R), ConfigureColor(data[1], pixel.G), ConfigureColor(data[2], pixel.B)));
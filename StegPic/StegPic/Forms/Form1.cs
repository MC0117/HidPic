using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StegPic.Models;

namespace StegPic
{
    public partial class StegGUI : Form
    {
        Bitmap bmp = null;
        private string key;

        public StegGUI()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }



        private void decryptRadioBtn_Click(object sender, EventArgs e)
        {
            encryptRadioBtn.Checked = decryptRadioBtn.Checked;
            decryptRadioBtn.Checked = !(decryptRadioBtn.Checked);
            hiddenInformationTextBox.Clear();
            saveFileLabel.Text = "Save extracted information in .txt-file:";
        }

        private void encryptRadioBtn_Click(object sender, EventArgs e)
        {
            decryptRadioBtn.Checked = encryptRadioBtn.Checked;
            encryptRadioBtn.Checked = !(encryptRadioBtn.Checked);
            hiddenInformationTextBox.Clear();
            saveFileLabel.Text = "Save manipulated picture:";
        }




        private void ofdOpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG Image |*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picturePathTextBox.Text = ofd.FileName;
                fileNameLabel.Text = ofd.SafeFileName;
                initialPictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void sdfOpenButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (decryptRadioBtn.Checked)
            {
                sfd.Filter = "Text-file |*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    BinaryWriter bw = new BinaryWriter(File.Create(sfd.FileName));
                    bw.Write(hiddenInformationTextBox.Text);
                    bw.Dispose();
                }
            }
            else if (encryptRadioBtn.Checked)
            {
                sfd.Filter = "PNG Image |*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    //saving bitmap in diffrent imageformats based on FilterIndex of savefiledialog
                    bmp.Save(sfd.FileName, ImageFormat.Png);
                    /*
                    switch (sfd.FilterIndex)
                    {
                        case 0:
                            bmp.Save(sfd.FileName, ImageFormat.Png);
                            break;
                        case 1:
                            bmp.Save(sfd.FileName, ImageFormat.Jpeg);
                            break;
                    }
                    */
                }                          
            }
        }

        private void addKeyButton_Click(object sender, EventArgs e)
        {
            key = keyTextBox.Text;
            //key += key.Length < 10 ? 
            keyAddedLabel.Text = "Key added.";
            keyAddedLabel.ForeColor = Color.Green;
        }

        private void performButton_Click(object sender, EventArgs e)
        {
            bmp = (Bitmap)initialPictureBox.Image;
            if (encryptRadioBtn.Checked)
            {
                bmp = StegPerform.EmbedData(hiddenInformationTextBox.Text, bmp, key);
                MessageBox.Show("data successfully embedded");
                initialPictureBox.Image = bmp;
            }
            else
            {
                hiddenInformationTextBox.Text = StegPerform.ExtractData(bmp, key);
            }
        }
    }
}

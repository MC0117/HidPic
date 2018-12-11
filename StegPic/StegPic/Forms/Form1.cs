using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StegPic
{
    public partial class StegGUI : Form
    {
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

        }

        private void encryptRadioBtn_Click(object sender, EventArgs e)
        {
            decryptRadioBtn.Checked = encryptRadioBtn.Checked;
            encryptRadioBtn.Checked = !(encryptRadioBtn.Checked);
        }
    }
}

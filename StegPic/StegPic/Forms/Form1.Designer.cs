namespace StegPic
{
    partial class StegGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.decryptRadioBtn = new System.Windows.Forms.RadioButton();
            this.encryptRadioBtn = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addKeyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 318);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // decryptRadioBtn
            // 
            this.decryptRadioBtn.AutoSize = true;
            this.decryptRadioBtn.Location = new System.Drawing.Point(69, 25);
            this.decryptRadioBtn.Name = "decryptRadioBtn";
            this.decryptRadioBtn.Size = new System.Drawing.Size(58, 17);
            this.decryptRadioBtn.TabIndex = 1;
            this.decryptRadioBtn.TabStop = true;
            this.decryptRadioBtn.Text = "Extract";
            this.decryptRadioBtn.UseVisualStyleBackColor = true;
            this.decryptRadioBtn.Click += new System.EventHandler(this.decryptRadioBtn_Click);
            // 
            // encryptRadioBtn
            // 
            this.encryptRadioBtn.AutoSize = true;
            this.encryptRadioBtn.Location = new System.Drawing.Point(12, 25);
            this.encryptRadioBtn.Name = "encryptRadioBtn";
            this.encryptRadioBtn.Size = new System.Drawing.Size(51, 17);
            this.encryptRadioBtn.TabIndex = 2;
            this.encryptRadioBtn.TabStop = true;
            this.encryptRadioBtn.Text = "Insert";
            this.encryptRadioBtn.UseVisualStyleBackColor = true;
            this.encryptRadioBtn.Click += new System.EventHandler(this.encryptRadioBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 550);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(552, 173);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 523);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unencrypted message:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Picture URL:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 456);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 6;
            // 
            // addKeyButton
            // 
            this.addKeyButton.Location = new System.Drawing.Point(79, 482);
            this.addKeyButton.Name = "addKeyButton";
            this.addKeyButton.Size = new System.Drawing.Size(62, 26);
            this.addKeyButton.TabIndex = 7;
            this.addKeyButton.Text = "Add";
            this.addKeyButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A key can be used for ensuring non-intended users to access hidden information (o" +
    "ptional). Maximum 10 characters.\r\n";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Location = new System.Drawing.Point(9, 9);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(357, 13);
            this.methodLabel.TabIndex = 12;
            this.methodLabel.Text = "Choose wether information should be inserted or extracted from picture-file:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Perform";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StegGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(586, 794);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addKeyButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.encryptRadioBtn);
            this.Controls.Add(this.decryptRadioBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StegGUI";
            this.Text = "Stegger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton decryptRadioBtn;
        private System.Windows.Forms.RadioButton encryptRadioBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button addKeyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Button button1;
    }
}


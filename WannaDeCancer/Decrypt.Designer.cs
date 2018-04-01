namespace WannaDeCancer
{
    partial class Decrypt
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
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.lbOutbutDes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbChooseFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.btnChooseKey = new System.Windows.Forms.Button();
            this.ckbLocalKey = new System.Windows.Forms.CheckBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txbStreamIN = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbSelectiveStream = new System.Windows.Forms.Label();
            this.txbStreamOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.SystemColors.MenuText;
            this.txbOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txbOutput.ForeColor = System.Drawing.Color.DarkGreen;
            this.txbOutput.Location = new System.Drawing.Point(0, 450);
            this.txbOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ReadOnly = true;
            this.txbOutput.Size = new System.Drawing.Size(1251, 299);
            this.txbOutput.TabIndex = 0;
            // 
            // lbOutbutDes
            // 
            this.lbOutbutDes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOutbutDes.AutoSize = true;
            this.lbOutbutDes.BackColor = System.Drawing.Color.Black;
            this.lbOutbutDes.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutbutDes.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOutbutDes.Location = new System.Drawing.Point(1178, 464);
            this.lbOutbutDes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOutbutDes.Name = "lbOutbutDes";
            this.lbOutbutDes.Size = new System.Drawing.Size(60, 23);
            this.lbOutbutDes.TabIndex = 1;
            this.lbOutbutDes.Text = "Output:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(708, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "In theory, The process will run automatically. But if you find some file remain e" +
    "ncrypted, Use these option below";
            // 
            // txbChooseFile
            // 
            this.txbChooseFile.Location = new System.Drawing.Point(94, 106);
            this.txbChooseFile.Name = "txbChooseFile";
            this.txbChooseFile.ReadOnly = true;
            this.txbChooseFile.Size = new System.Drawing.Size(539, 26);
            this.txbChooseFile.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "FIle Name:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(613, 105);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(29, 27);
            this.btnChooseFile.TabIndex = 6;
            this.btnChooseFile.Text = "...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(13, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Key Gen:";
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(94, 166);
            this.txbKey.Name = "txbKey";
            this.txbKey.ReadOnly = true;
            this.txbKey.Size = new System.Drawing.Size(399, 26);
            this.txbKey.TabIndex = 8;
            // 
            // btnChooseKey
            // 
            this.btnChooseKey.Location = new System.Drawing.Point(464, 166);
            this.btnChooseKey.Name = "btnChooseKey";
            this.btnChooseKey.Size = new System.Drawing.Size(29, 27);
            this.btnChooseKey.TabIndex = 9;
            this.btnChooseKey.Text = "...";
            this.btnChooseKey.UseVisualStyleBackColor = true;
            this.btnChooseKey.Click += new System.EventHandler(this.btnChooseKey_Click);
            // 
            // ckbLocalKey
            // 
            this.ckbLocalKey.AutoSize = true;
            this.ckbLocalKey.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ckbLocalKey.Location = new System.Drawing.Point(499, 168);
            this.ckbLocalKey.Name = "ckbLocalKey";
            this.ckbLocalKey.Size = new System.Drawing.Size(148, 24);
            this.ckbLocalKey.TabIndex = 10;
            this.ckbLocalKey.Text = "Use the local key";
            this.ckbLocalKey.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(432, 208);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(201, 54);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt This File";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txbStreamIN
            // 
            this.txbStreamIN.BackColor = System.Drawing.SystemColors.MenuText;
            this.txbStreamIN.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStreamIN.ForeColor = System.Drawing.Color.Lime;
            this.txbStreamIN.Location = new System.Drawing.Point(747, 31);
            this.txbStreamIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbStreamIN.Multiline = true;
            this.txbStreamIN.Name = "txbStreamIN";
            this.txbStreamIN.Size = new System.Drawing.Size(491, 202);
            this.txbStreamIN.TabIndex = 12;
            this.txbStreamIN.Text = "<Insert Stream Here>";
            this.txbStreamIN.Click += new System.EventHandler(this.txbStreamIN_Click);
            this.txbStreamIN.Leave += new System.EventHandler(this.txbStreamIN_Leave);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbTitle.Location = new System.Drawing.Point(13, 9);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(620, 17);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Please wait, Your file is being decrypted. You may Close the window when the outp" +
    "ut return Done!";
            // 
            // lbSelectiveStream
            // 
            this.lbSelectiveStream.AutoSize = true;
            this.lbSelectiveStream.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectiveStream.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbSelectiveStream.Location = new System.Drawing.Point(744, 9);
            this.lbSelectiveStream.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSelectiveStream.Name = "lbSelectiveStream";
            this.lbSelectiveStream.Size = new System.Drawing.Size(104, 17);
            this.lbSelectiveStream.TabIndex = 13;
            this.lbSelectiveStream.Text = "Selective Steam";
            // 
            // txbStreamOut
            // 
            this.txbStreamOut.BackColor = System.Drawing.SystemColors.MenuText;
            this.txbStreamOut.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbStreamOut.ForeColor = System.Drawing.Color.Lime;
            this.txbStreamOut.Location = new System.Drawing.Point(747, 238);
            this.txbStreamOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txbStreamOut.Multiline = true;
            this.txbStreamOut.Name = "txbStreamOut";
            this.txbStreamOut.ReadOnly = true;
            this.txbStreamOut.Size = new System.Drawing.Size(491, 202);
            this.txbStreamOut.TabIndex = 14;
            this.txbStreamOut.Text = "<Output>";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1169, 240);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Output:";
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1251, 749);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbStreamOut);
            this.Controls.Add(this.lbSelectiveStream);
            this.Controls.Add(this.txbStreamIN);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.ckbLocalKey);
            this.Controls.Add(this.btnChooseKey);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChooseFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbChooseFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbOutbutDes);
            this.Controls.Add(this.txbOutput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Decrypt";
            this.Text = "Decrypt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Decrypt_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Label lbOutbutDes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbChooseFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.Button btnChooseKey;
        private System.Windows.Forms.CheckBox ckbLocalKey;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txbStreamIN;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSelectiveStream;
        private System.Windows.Forms.TextBox txbStreamOut;
        private System.Windows.Forms.Label label1;
    }
}
namespace WannaDeCancer
{
    partial class WannaDeCancer
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
            this.ptbInit = new System.Windows.Forms.PictureBox();
            this.pbInit = new System.Windows.Forms.ProgressBar();
            this.lbCursor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbInit)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbInit
            // 
            this.ptbInit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbInit.Image = global::WannaDeCancer.Properties.Resources.Starting;
            this.ptbInit.Location = new System.Drawing.Point(0, 0);
            this.ptbInit.Name = "ptbInit";
            this.ptbInit.Size = new System.Drawing.Size(1281, 769);
            this.ptbInit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbInit.TabIndex = 0;
            this.ptbInit.TabStop = false;
            // 
            // pbInit
            // 
            this.pbInit.Location = new System.Drawing.Point(12, 679);
            this.pbInit.Name = "pbInit";
            this.pbInit.Size = new System.Drawing.Size(1257, 45);
            this.pbInit.TabIndex = 1;
            // 
            // lbCursor
            // 
            this.lbCursor.AutoSize = true;
            this.lbCursor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCursor.ForeColor = System.Drawing.Color.Red;
            this.lbCursor.Location = new System.Drawing.Point(359, 533);
            this.lbCursor.Name = "lbCursor";
            this.lbCursor.Size = new System.Drawing.Size(156, 37);
            this.lbCursor.TabIndex = 2;
            this.lbCursor.Text = "Cancer!!!";
            // 
            // WannaDeCancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 769);
            this.Controls.Add(this.lbCursor);
            this.Controls.Add(this.pbInit);
            this.Controls.Add(this.ptbInit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WannaDeCancer";
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ptbInit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbInit;
        private System.Windows.Forms.ProgressBar pbInit;
        private System.Windows.Forms.Label lbCursor;
    }
}


namespace PrjForm
{
    partial class FrmCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCheck));
            this.GrbCheck = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.PicIntel = new System.Windows.Forms.PictureBox();
            this.PicAMD = new System.Windows.Forms.PictureBox();
            this.PicNvidia = new System.Windows.Forms.PictureBox();
            this.ChkAMD111 = new System.Windows.Forms.CheckBox();
            this.ChkIntel111 = new System.Windows.Forms.CheckBox();
            this.ChkNvidia111 = new System.Windows.Forms.CheckBox();
            this.GrbCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIntel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAMD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNvidia)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbCheck
            // 
            this.GrbCheck.BackColor = System.Drawing.Color.SeaGreen;
            this.GrbCheck.Controls.Add(this.button2);
            this.GrbCheck.Controls.Add(this.PicIntel);
            this.GrbCheck.Controls.Add(this.PicAMD);
            this.GrbCheck.Controls.Add(this.PicNvidia);
            this.GrbCheck.Controls.Add(this.ChkAMD111);
            this.GrbCheck.Controls.Add(this.ChkIntel111);
            this.GrbCheck.Controls.Add(this.ChkNvidia111);
            this.GrbCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbCheck.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.GrbCheck.Location = new System.Drawing.Point(12, 12);
            this.GrbCheck.Name = "GrbCheck";
            this.GrbCheck.Size = new System.Drawing.Size(476, 328);
            this.GrbCheck.TabIndex = 0;
            this.GrbCheck.TabStop = false;
            this.GrbCheck.Text = "Three Stuff";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(371, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicIntel
            // 
            this.PicIntel.Image = ((System.Drawing.Image)(resources.GetObject("PicIntel.Image")));
            this.PicIntel.Location = new System.Drawing.Point(115, 225);
            this.PicIntel.MaximumSize = new System.Drawing.Size(100, 100);
            this.PicIntel.Name = "PicIntel";
            this.PicIntel.Size = new System.Drawing.Size(61, 59);
            this.PicIntel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicIntel.TabIndex = 7;
            this.PicIntel.TabStop = false;
            this.PicIntel.Visible = false;
            // 
            // PicAMD
            // 
            this.PicAMD.Image = ((System.Drawing.Image)(resources.GetObject("PicAMD.Image")));
            this.PicAMD.Location = new System.Drawing.Point(115, 124);
            this.PicAMD.MaximumSize = new System.Drawing.Size(100, 100);
            this.PicAMD.Name = "PicAMD";
            this.PicAMD.Size = new System.Drawing.Size(61, 59);
            this.PicAMD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicAMD.TabIndex = 6;
            this.PicAMD.TabStop = false;
            this.PicAMD.Visible = false;
            // 
            // PicNvidia
            // 
            this.PicNvidia.Image = ((System.Drawing.Image)(resources.GetObject("PicNvidia.Image")));
            this.PicNvidia.Location = new System.Drawing.Point(115, 28);
            this.PicNvidia.MaximumSize = new System.Drawing.Size(100, 100);
            this.PicNvidia.Name = "PicNvidia";
            this.PicNvidia.Size = new System.Drawing.Size(61, 59);
            this.PicNvidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicNvidia.TabIndex = 5;
            this.PicNvidia.TabStop = false;
            this.PicNvidia.Visible = false;
            this.PicNvidia.Click += new System.EventHandler(this.PicNvidia_Click);
            // 
            // ChkAMD111
            // 
            this.ChkAMD111.AutoSize = true;
            this.ChkAMD111.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.ChkAMD111.Location = new System.Drawing.Point(20, 143);
            this.ChkAMD111.Name = "ChkAMD111";
            this.ChkAMD111.Size = new System.Drawing.Size(66, 25);
            this.ChkAMD111.TabIndex = 2;
            this.ChkAMD111.Text = "AMD";
            this.ChkAMD111.UseVisualStyleBackColor = true;
            this.ChkAMD111.CheckedChanged += new System.EventHandler(this.ChkAMD_CheckedChanged);
            // 
            // ChkIntel111
            // 
            this.ChkIntel111.AutoSize = true;
            this.ChkIntel111.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.ChkIntel111.Location = new System.Drawing.Point(23, 248);
            this.ChkIntel111.Name = "ChkIntel111";
            this.ChkIntel111.Size = new System.Drawing.Size(62, 25);
            this.ChkIntel111.TabIndex = 1;
            this.ChkIntel111.Text = "Intel";
            this.ChkIntel111.UseVisualStyleBackColor = true;
            this.ChkIntel111.CheckedChanged += new System.EventHandler(this.ChkIntel_CheckedChanged);
            // 
            // ChkNvidia111
            // 
            this.ChkNvidia111.AutoSize = true;
            this.ChkNvidia111.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.ChkNvidia111.Location = new System.Drawing.Point(23, 42);
            this.ChkNvidia111.Name = "ChkNvidia111";
            this.ChkNvidia111.Size = new System.Drawing.Size(83, 25);
            this.ChkNvidia111.TabIndex = 0;
            this.ChkNvidia111.Text = "NVIDIA";
            this.ChkNvidia111.UseVisualStyleBackColor = true;
            this.ChkNvidia111.CheckedChanged += new System.EventHandler(this.ChkNvidia_CheckedChanged);
            // 
            // FrmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(501, 354);
            this.Controls.Add(this.GrbCheck);
            this.Name = "FrmCheck";
            this.Text = "CHECKMATE";
            this.GrbCheck.ResumeLayout(false);
            this.GrbCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIntel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAMD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicNvidia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbCheck;
        private System.Windows.Forms.CheckBox ChkAMD111;
        private System.Windows.Forms.CheckBox ChkIntel111;
        private System.Windows.Forms.CheckBox ChkNvidia111;
        private System.Windows.Forms.PictureBox PicNvidia;
        private System.Windows.Forms.PictureBox PicIntel;
        private System.Windows.Forms.PictureBox PicAMD;
        private System.Windows.Forms.Button button2;
    }
}
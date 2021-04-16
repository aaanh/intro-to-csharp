namespace PrjForm
{
    partial class FrmMouseEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMouseEvents));
            this.BtnUp = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnDown = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PicTetris = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlAnotherOne = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTetris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnUp
            // 
            this.BtnUp.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnUp.Location = new System.Drawing.Point(469, 382);
            this.BtnUp.Name = "BtnUp";
            this.BtnUp.Size = new System.Drawing.Size(78, 40);
            this.BtnUp.TabIndex = 0;
            this.BtnUp.Text = "UP";
            this.BtnUp.UseVisualStyleBackColor = true;
            this.BtnUp.Click += new System.EventHandler(this.BtnUp_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnLeft.Location = new System.Drawing.Point(393, 420);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(78, 40);
            this.BtnLeft.TabIndex = 1;
            this.BtnLeft.Text = "LEFT";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRight.Location = new System.Drawing.Point(546, 420);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(78, 40);
            this.BtnRight.TabIndex = 2;
            this.BtnRight.Text = "RIGHT";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnDown
            // 
            this.BtnDown.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDown.Location = new System.Drawing.Point(469, 420);
            this.BtnDown.Name = "BtnDown";
            this.BtnDown.Size = new System.Drawing.Size(78, 40);
            this.BtnDown.TabIndex = 3;
            this.BtnDown.Text = "DOWN";
            this.BtnDown.UseVisualStyleBackColor = true;
            this.BtnDown.Click += new System.EventHandler(this.BtnDown_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PicTetris);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 437);
            this.panel1.TabIndex = 4;
            // 
            // PicTetris
            // 
            this.PicTetris.BackColor = System.Drawing.Color.Transparent;
            this.PicTetris.Image = ((System.Drawing.Image)(resources.GetObject("PicTetris.Image")));
            this.PicTetris.Location = new System.Drawing.Point(117, 162);
            this.PicTetris.Name = "PicTetris";
            this.PicTetris.Size = new System.Drawing.Size(52, 53);
            this.PicTetris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicTetris.TabIndex = 1;
            this.PicTetris.TabStop = false;
            this.PicTetris.Click += new System.EventHandler(this.PicTetris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlAnotherOne
            // 
            this.PnlAnotherOne.Location = new System.Drawing.Point(382, 12);
            this.PnlAnotherOne.Name = "PnlAnotherOne";
            this.PnlAnotherOne.Size = new System.Drawing.Size(200, 100);
            this.PnlAnotherOne.TabIndex = 5;
            this.PnlAnotherOne.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.PnlAnotherOne.MouseLeave += new System.EventHandler(this.PnlAnotherOne_MouseLeave);
            // 
            // FrmMouseEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(652, 472);
            this.Controls.Add(this.PnlAnotherOne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnDown);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.BtnUp);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.CadetBlue;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMouseEvents";
            this.Text = "Mouse Events";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTetris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUp;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PicTetris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PnlAnotherOne;
    }
}
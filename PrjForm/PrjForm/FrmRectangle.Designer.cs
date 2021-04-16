namespace PrjForm
{
    partial class FrmRectangle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCLR = new System.Windows.Forms.Button();
            this.BtnEQU = new System.Windows.Forms.Button();
            this.BtnHelp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtWidth = new System.Windows.Forms.TextBox();
            this.TxtLength = new System.Windows.Forms.TextBox();
            this.LblArea = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCLR);
            this.panel1.Controls.Add(this.BtnEQU);
            this.panel1.Controls.Add(this.BtnHelp);
            this.panel1.Location = new System.Drawing.Point(133, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 144);
            this.panel1.TabIndex = 0;
            // 
            // BtnCLR
            // 
            this.BtnCLR.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnCLR.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCLR.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCLR.Location = new System.Drawing.Point(3, 23);
            this.BtnCLR.Name = "BtnCLR";
            this.BtnCLR.Size = new System.Drawing.Size(144, 92);
            this.BtnCLR.TabIndex = 4;
            this.BtnCLR.Text = "CLRSCR";
            this.BtnCLR.UseVisualStyleBackColor = false;
            this.BtnCLR.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // BtnEQU
            // 
            this.BtnEQU.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEQU.Enabled = false;
            this.BtnEQU.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEQU.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEQU.Location = new System.Drawing.Point(220, 23);
            this.BtnEQU.Name = "BtnEQU";
            this.BtnEQU.Size = new System.Drawing.Size(144, 92);
            this.BtnEQU.TabIndex = 0;
            this.BtnEQU.Text = "EQUAL";
            this.BtnEQU.UseVisualStyleBackColor = false;
            this.BtnEQU.Click += new System.EventHandler(this.BtnCLR_Click);
            // 
            // BtnHelp
            // 
            this.BtnHelp.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnHelp.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnHelp.Location = new System.Drawing.Point(434, 23);
            this.BtnHelp.Name = "BtnHelp";
            this.BtnHelp.Size = new System.Drawing.Size(144, 92);
            this.BtnHelp.TabIndex = 5;
            this.BtnHelp.Text = "FUCK";
            this.BtnHelp.UseVisualStyleBackColor = false;
            this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(133, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "WIDTH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(353, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "LENGTH";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtWidth
            // 
            this.TxtWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtWidth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtWidth.Location = new System.Drawing.Point(133, 177);
            this.TxtWidth.Multiline = true;
            this.TxtWidth.Name = "TxtWidth";
            this.TxtWidth.Size = new System.Drawing.Size(144, 76);
            this.TxtWidth.TabIndex = 7;
            this.TxtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtWidth.TextChanged += new System.EventHandler(this.TxtWidth_TextChanged);
            // 
            // TxtLength
            // 
            this.TxtLength.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TxtLength.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLength.Location = new System.Drawing.Point(353, 177);
            this.TxtLength.Multiline = true;
            this.TxtLength.Name = "TxtLength";
            this.TxtLength.Size = new System.Drawing.Size(144, 76);
            this.TxtLength.TabIndex = 8;
            this.TxtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtLength.TextChanged += new System.EventHandler(this.TxtLength_TextChanged);
            // 
            // LblArea
            // 
            this.LblArea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LblArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblArea.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.Location = new System.Drawing.Point(570, 177);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(144, 76);
            this.LblArea.TabIndex = 9;
            this.LblArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblArea.Click += new System.EventHandler(this.LblArea_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(570, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "AREA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(376, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(826, 584);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.TxtLength);
            this.Controls.Add(this.TxtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRectangle";
            this.Text = "FrmRectangle";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEQU;
        private System.Windows.Forms.Button BtnCLR;
        private System.Windows.Forms.Button BtnHelp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtWidth;
        private System.Windows.Forms.TextBox TxtLength;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}
namespace PrjForm
{
    partial class FrmExam1700362_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmExam1700362_1));
            this.ChkBurgers = new System.Windows.Forms.CheckBox();
            this.ChkFries = new System.Windows.Forms.CheckBox();
            this.ChkDrinks = new System.Windows.Forms.CheckBox();
            this.HScBurgers = new System.Windows.Forms.HScrollBar();
            this.HscFries = new System.Windows.Forms.HScrollBar();
            this.HScDrinks = new System.Windows.Forms.HScrollBar();
            this.LabelQuantity = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LblQBurgers = new System.Windows.Forms.Label();
            this.LblQFries = new System.Windows.Forms.Label();
            this.LblQDrinks = new System.Windows.Forms.Label();
            this.LblPBurgers = new System.Windows.Forms.Label();
            this.LblPFries = new System.Windows.Forms.Label();
            this.LblPDrinks = new System.Windows.Forms.Label();
            this.LblSub = new System.Windows.Forms.Label();
            this.LabelSubtotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnClr = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkBurgers
            // 
            this.ChkBurgers.AutoSize = true;
            this.ChkBurgers.BackColor = System.Drawing.Color.SeaGreen;
            this.ChkBurgers.Location = new System.Drawing.Point(46, 120);
            this.ChkBurgers.Name = "ChkBurgers";
            this.ChkBurgers.Size = new System.Drawing.Size(108, 34);
            this.ChkBurgers.TabIndex = 0;
            this.ChkBurgers.Text = "Burgers";
            this.ChkBurgers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkBurgers.UseVisualStyleBackColor = false;
            this.ChkBurgers.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ChkFries
            // 
            this.ChkFries.BackColor = System.Drawing.Color.SeaGreen;
            this.ChkFries.Location = new System.Drawing.Point(46, 202);
            this.ChkFries.Name = "ChkFries";
            this.ChkFries.Size = new System.Drawing.Size(108, 34);
            this.ChkFries.TabIndex = 1;
            this.ChkFries.Text = "Fries";
            this.ChkFries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkFries.UseVisualStyleBackColor = false;
            this.ChkFries.CheckedChanged += new System.EventHandler(this.ChkFries_CheckedChanged);
            // 
            // ChkDrinks
            // 
            this.ChkDrinks.BackColor = System.Drawing.Color.SeaGreen;
            this.ChkDrinks.Location = new System.Drawing.Point(46, 285);
            this.ChkDrinks.Name = "ChkDrinks";
            this.ChkDrinks.Size = new System.Drawing.Size(108, 34);
            this.ChkDrinks.TabIndex = 2;
            this.ChkDrinks.Text = "Drinks";
            this.ChkDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChkDrinks.UseVisualStyleBackColor = false;
            this.ChkDrinks.CheckedChanged += new System.EventHandler(this.ChkDrinks_CheckedChanged);
            // 
            // HScBurgers
            // 
            this.HScBurgers.Enabled = false;
            this.HScBurgers.Location = new System.Drawing.Point(196, 130);
            this.HScBurgers.Maximum = 1000;
            this.HScBurgers.Name = "HScBurgers";
            this.HScBurgers.Size = new System.Drawing.Size(80, 17);
            this.HScBurgers.TabIndex = 3;
            this.HScBurgers.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // HscFries
            // 
            this.HscFries.Enabled = false;
            this.HscFries.Location = new System.Drawing.Point(196, 210);
            this.HscFries.Maximum = 1000;
            this.HscFries.Name = "HscFries";
            this.HscFries.Size = new System.Drawing.Size(80, 17);
            this.HscFries.TabIndex = 4;
            this.HscFries.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HscFries_Scroll);
            // 
            // HScDrinks
            // 
            this.HScDrinks.Enabled = false;
            this.HScDrinks.Location = new System.Drawing.Point(196, 293);
            this.HScDrinks.Maximum = 1000;
            this.HScDrinks.Name = "HScDrinks";
            this.HScDrinks.Size = new System.Drawing.Size(80, 17);
            this.HScDrinks.TabIndex = 5;
            this.HScDrinks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HScDrinks_Scroll);
            // 
            // LabelQuantity
            // 
            this.LabelQuantity.Location = new System.Drawing.Point(381, 53);
            this.LabelQuantity.Name = "LabelQuantity";
            this.LabelQuantity.Size = new System.Drawing.Size(122, 30);
            this.LabelQuantity.TabIndex = 6;
            this.LabelQuantity.Text = "QUANTITY";
            this.LabelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPrice
            // 
            this.LabelPrice.Location = new System.Drawing.Point(634, 53);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(120, 30);
            this.LabelPrice.TabIndex = 7;
            this.LabelPrice.Text = "PRICE";
            this.LabelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblQBurgers
            // 
            this.LblQBurgers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblQBurgers.Enabled = false;
            this.LblQBurgers.Location = new System.Drawing.Point(386, 120);
            this.LblQBurgers.Name = "LblQBurgers";
            this.LblQBurgers.Size = new System.Drawing.Size(117, 34);
            this.LblQBurgers.TabIndex = 8;
            this.LblQBurgers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblQFries
            // 
            this.LblQFries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblQFries.Enabled = false;
            this.LblQFries.Location = new System.Drawing.Point(386, 201);
            this.LblQFries.Name = "LblQFries";
            this.LblQFries.Size = new System.Drawing.Size(117, 34);
            this.LblQFries.TabIndex = 9;
            this.LblQFries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblQDrinks
            // 
            this.LblQDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblQDrinks.Enabled = false;
            this.LblQDrinks.Location = new System.Drawing.Point(386, 276);
            this.LblQDrinks.Name = "LblQDrinks";
            this.LblQDrinks.Size = new System.Drawing.Size(117, 34);
            this.LblQDrinks.TabIndex = 10;
            this.LblQDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPBurgers
            // 
            this.LblPBurgers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPBurgers.Enabled = false;
            this.LblPBurgers.Location = new System.Drawing.Point(637, 119);
            this.LblPBurgers.Name = "LblPBurgers";
            this.LblPBurgers.Size = new System.Drawing.Size(117, 34);
            this.LblPBurgers.TabIndex = 11;
            this.LblPBurgers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPFries
            // 
            this.LblPFries.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPFries.Enabled = false;
            this.LblPFries.Location = new System.Drawing.Point(639, 201);
            this.LblPFries.Name = "LblPFries";
            this.LblPFries.Size = new System.Drawing.Size(117, 34);
            this.LblPFries.TabIndex = 12;
            this.LblPFries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPDrinks
            // 
            this.LblPDrinks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPDrinks.Enabled = false;
            this.LblPDrinks.Location = new System.Drawing.Point(637, 276);
            this.LblPDrinks.Name = "LblPDrinks";
            this.LblPDrinks.Size = new System.Drawing.Size(117, 34);
            this.LblPDrinks.TabIndex = 13;
            this.LblPDrinks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblSub
            // 
            this.LblSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblSub.Location = new System.Drawing.Point(639, 349);
            this.LblSub.Name = "LblSub";
            this.LblSub.Size = new System.Drawing.Size(117, 34);
            this.LblSub.TabIndex = 14;
            this.LblSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelSubtotal
            // 
            this.LabelSubtotal.Location = new System.Drawing.Point(370, 349);
            this.LabelSubtotal.Name = "LabelSubtotal";
            this.LabelSubtotal.Size = new System.Drawing.Size(150, 30);
            this.LabelSubtotal.TabIndex = 15;
            this.LabelSubtotal.Text = "SUB-TOTAL";
            this.LabelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(370, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "TAX 12%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTax
            // 
            this.LblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTax.Location = new System.Drawing.Point(639, 416);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(117, 34);
            this.LblTax.TabIndex = 16;
            this.LblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(370, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "TOTAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblTotal
            // 
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblTotal.Location = new System.Drawing.Point(639, 478);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(117, 34);
            this.LblTotal.TabIndex = 18;
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnCalc
            // 
            this.BtnCalc.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnCalc.Location = new System.Drawing.Point(186, 349);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(108, 68);
            this.BtnCalc.TabIndex = 20;
            this.BtnCalc.Text = "CALC";
            this.BtnCalc.UseVisualStyleBackColor = true;
            // 
            // BtnClr
            // 
            this.BtnClr.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnClr.Location = new System.Drawing.Point(186, 449);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Size = new System.Drawing.Size(108, 68);
            this.BtnClr.TabIndex = 21;
            this.BtnClr.Text = "CLR";
            this.BtnClr.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.textBox1.ForeColor = System.Drawing.Color.OldLace;
            this.textBox1.Location = new System.Drawing.Point(34, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(285, 42);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "FEED THE TAMAMO";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // FrmExam1700362_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(796, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnClr);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.LabelSubtotal);
            this.Controls.Add(this.LblSub);
            this.Controls.Add(this.LblPDrinks);
            this.Controls.Add(this.LblPFries);
            this.Controls.Add(this.LblPBurgers);
            this.Controls.Add(this.LblQDrinks);
            this.Controls.Add(this.LblQFries);
            this.Controls.Add(this.LblQBurgers);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.LabelQuantity);
            this.Controls.Add(this.HScDrinks);
            this.Controls.Add(this.HscFries);
            this.Controls.Add(this.HScBurgers);
            this.Controls.Add(this.ChkDrinks);
            this.Controls.Add(this.ChkFries);
            this.Controls.Add(this.ChkBurgers);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 16F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FrmExam1700362_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "キャットフード";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkBurgers;
        private System.Windows.Forms.CheckBox ChkFries;
        private System.Windows.Forms.CheckBox ChkDrinks;
        private System.Windows.Forms.HScrollBar HScBurgers;
        private System.Windows.Forms.HScrollBar HscFries;
        private System.Windows.Forms.HScrollBar HScDrinks;
        private System.Windows.Forms.Label LabelQuantity;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LblQBurgers;
        private System.Windows.Forms.Label LblQFries;
        private System.Windows.Forms.Label LblQDrinks;
        private System.Windows.Forms.Label LblPBurgers;
        private System.Windows.Forms.Label LblPFries;
        private System.Windows.Forms.Label LblPDrinks;
        private System.Windows.Forms.Label LblSub;
        private System.Windows.Forms.Label LabelSubtotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnClr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
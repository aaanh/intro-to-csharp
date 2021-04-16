namespace PrjMenu3
{
    partial class FrmLoan
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
            this.NudLoan = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblRate = new System.Windows.Forms.Label();
            this.LblYear = new System.Windows.Forms.Label();
            this.HsbRate = new System.Windows.Forms.HScrollBar();
            this.HsbYear = new System.Windows.Forms.HScrollBar();
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnClr = new System.Windows.Forms.Button();
            this.GrbResults = new System.Windows.Forms.GroupBox();
            this.LblSum = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudLoan)).BeginInit();
            this.GrbResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // NudLoan
            // 
            this.NudLoan.DecimalPlaces = 2;
            this.NudLoan.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NudLoan.Location = new System.Drawing.Point(368, 119);
            this.NudLoan.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.NudLoan.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudLoan.Name = "NudLoan";
            this.NudLoan.Size = new System.Drawing.Size(120, 29);
            this.NudLoan.TabIndex = 0;
            this.NudLoan.ThousandsSeparator = true;
            this.NudLoan.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudLoan.ValueChanged += new System.EventHandler(this.NudLoan_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label1.Location = new System.Drawing.Point(169, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loan Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label2.Location = new System.Drawing.Point(169, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate in %";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label3.Location = new System.Drawing.Point(169, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Years";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRate
            // 
            this.LblRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LblRate.Location = new System.Drawing.Point(368, 197);
            this.LblRate.Name = "LblRate";
            this.LblRate.Size = new System.Drawing.Size(144, 61);
            this.LblRate.TabIndex = 4;
            this.LblRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblYear
            // 
            this.LblYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LblYear.Location = new System.Drawing.Point(368, 273);
            this.LblYear.Name = "LblYear";
            this.LblYear.Size = new System.Drawing.Size(144, 62);
            this.LblYear.TabIndex = 5;
            this.LblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HsbRate
            // 
            this.HsbRate.Location = new System.Drawing.Point(173, 226);
            this.HsbRate.Name = "HsbRate";
            this.HsbRate.Size = new System.Drawing.Size(144, 17);
            this.HsbRate.TabIndex = 6;
            this.HsbRate.TabStop = true;
            this.HsbRate.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbRate_Scroll);
            // 
            // HsbYear
            // 
            this.HsbYear.LargeChange = 5;
            this.HsbYear.Location = new System.Drawing.Point(173, 302);
            this.HsbYear.Maximum = 50;
            this.HsbYear.Name = "HsbYear";
            this.HsbYear.Size = new System.Drawing.Size(144, 17);
            this.HsbYear.TabIndex = 7;
            this.HsbYear.TabStop = true;
            this.HsbYear.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HsbYear_Scroll);
            // 
            // BtnCalc
            // 
            this.BtnCalc.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnCalc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.BtnCalc.Location = new System.Drawing.Point(173, 372);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(144, 76);
            this.BtnCalc.TabIndex = 8;
            this.BtnCalc.Text = "CALC";
            this.BtnCalc.UseVisualStyleBackColor = false;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnClr
            // 
            this.BtnClr.BackColor = System.Drawing.Color.DarkSalmon;
            this.BtnClr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.BtnClr.Location = new System.Drawing.Point(368, 372);
            this.BtnClr.Name = "BtnClr";
            this.BtnClr.Size = new System.Drawing.Size(144, 76);
            this.BtnClr.TabIndex = 9;
            this.BtnClr.Text = "CLR";
            this.BtnClr.UseVisualStyleBackColor = false;
            this.BtnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // GrbResults
            // 
            this.GrbResults.Controls.Add(this.LblSum);
            this.GrbResults.Controls.Add(this.label7);
            this.GrbResults.Controls.Add(this.LblPayment);
            this.GrbResults.Controls.Add(this.label5);
            this.GrbResults.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbResults.ForeColor = System.Drawing.Color.White;
            this.GrbResults.Location = new System.Drawing.Point(544, 119);
            this.GrbResults.Name = "GrbResults";
            this.GrbResults.Size = new System.Drawing.Size(422, 329);
            this.GrbResults.TabIndex = 10;
            this.GrbResults.TabStop = false;
            this.GrbResults.Text = "PAYMENT";
            // 
            // LblSum
            // 
            this.LblSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblSum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LblSum.Location = new System.Drawing.Point(222, 168);
            this.LblSum.Name = "LblSum";
            this.LblSum.Size = new System.Drawing.Size(144, 61);
            this.LblSum.TabIndex = 14;
            this.LblSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label7.Location = new System.Drawing.Point(24, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "SUM OF PAYMENT";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPayment
            // 
            this.LblPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.LblPayment.Location = new System.Drawing.Point(222, 62);
            this.LblPayment.Name = "LblPayment";
            this.LblPayment.Size = new System.Drawing.Size(144, 61);
            this.LblPayment.TabIndex = 12;
            this.LblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label5.Location = new System.Drawing.Point(24, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "PAYMENT";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1374, 821);
            this.Controls.Add(this.GrbResults);
            this.Controls.Add(this.BtnClr);
            this.Controls.Add(this.BtnCalc);
            this.Controls.Add(this.HsbYear);
            this.Controls.Add(this.HsbRate);
            this.Controls.Add(this.LblYear);
            this.Controls.Add(this.LblRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NudLoan);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmLoan";
            this.Text = "Loan Sharks";
            ((System.ComponentModel.ISupportInitialize)(this.NudLoan)).EndInit();
            this.GrbResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NudLoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblRate;
        private System.Windows.Forms.Label LblYear;
        private System.Windows.Forms.HScrollBar HsbRate;
        private System.Windows.Forms.HScrollBar HsbYear;
        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnClr;
        private System.Windows.Forms.GroupBox GrbResults;
        private System.Windows.Forms.Label LblSum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblPayment;
        private System.Windows.Forms.Label label5;
    }
}


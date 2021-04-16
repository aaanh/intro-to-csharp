namespace PrjExam2_1700362
{
    partial class FrmExam2
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
            this.Label_Yearly_Salary = new System.Windows.Forms.Label();
            this.NudSalary = new System.Windows.Forms.NumericUpDown();
            this.Label_Contribution = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nGUYENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAMILYNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hOANGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mIDDLENAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIRSTNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORFOREIGNSPEAKERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TrbContribution = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblContribution = new System.Windows.Forms.Label();
            this.GrbTaxes = new System.Windows.Forms.GroupBox();
            this.ChkProvincial = new System.Windows.Forms.CheckBox();
            this.ChkFederal = new System.Windows.Forms.CheckBox();
            this.GrbInsurance = new System.Windows.Forms.GroupBox();
            this.ChkFamily = new System.Windows.Forms.RadioButton();
            this.ChkIndividual = new System.Windows.Forms.RadioButton();
            this.ChkNone = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblPay = new System.Windows.Forms.Label();
            this.LblNetpay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudSalary)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbContribution)).BeginInit();
            this.GrbTaxes.SuspendLayout();
            this.GrbInsurance.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Yearly_Salary
            // 
            this.Label_Yearly_Salary.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Label_Yearly_Salary.Location = new System.Drawing.Point(120, 40);
            this.Label_Yearly_Salary.Name = "Label_Yearly_Salary";
            this.Label_Yearly_Salary.Size = new System.Drawing.Size(150, 28);
            this.Label_Yearly_Salary.TabIndex = 0;
            this.Label_Yearly_Salary.Text = "YEARLY SALARY:";
            this.Label_Yearly_Salary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NudSalary
            // 
            this.NudSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudSalary.Location = new System.Drawing.Point(287, 39);
            this.NudSalary.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.NudSalary.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudSalary.Name = "NudSalary";
            this.NudSalary.Size = new System.Drawing.Size(152, 29);
            this.NudSalary.TabIndex = 1;
            this.NudSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudSalary.ThousandsSeparator = true;
            this.NudSalary.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudSalary.ValueChanged += new System.EventHandler(this.NudSalary_ValueChanged);
            // 
            // Label_Contribution
            // 
            this.Label_Contribution.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Label_Contribution.Location = new System.Drawing.Point(43, 93);
            this.Label_Contribution.Name = "Label_Contribution";
            this.Label_Contribution.Size = new System.Drawing.Size(470, 28);
            this.Label_Contribution.TabIndex = 2;
            this.Label_Contribution.Text = "RETIRMENT CONTRIBUTION";
            this.Label_Contribution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nGUYENToolStripMenuItem,
            this.hOANGToolStripMenuItem,
            this.aNHToolStripMenuItem,
            this.tEDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nGUYENToolStripMenuItem
            // 
            this.nGUYENToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAMILYNAMEToolStripMenuItem});
            this.nGUYENToolStripMenuItem.Name = "nGUYENToolStripMenuItem";
            this.nGUYENToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.nGUYENToolStripMenuItem.Text = "NGUYEN";
            // 
            // fAMILYNAMEToolStripMenuItem
            // 
            this.fAMILYNAMEToolStripMenuItem.Name = "fAMILYNAMEToolStripMenuItem";
            this.fAMILYNAMEToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fAMILYNAMEToolStripMenuItem.Text = "FAMILY NAME";
            // 
            // hOANGToolStripMenuItem
            // 
            this.hOANGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mIDDLENAMEToolStripMenuItem});
            this.hOANGToolStripMenuItem.Name = "hOANGToolStripMenuItem";
            this.hOANGToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.hOANGToolStripMenuItem.Text = "HOANG";
            // 
            // mIDDLENAMEToolStripMenuItem
            // 
            this.mIDDLENAMEToolStripMenuItem.Name = "mIDDLENAMEToolStripMenuItem";
            this.mIDDLENAMEToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.mIDDLENAMEToolStripMenuItem.Text = "MIDDLE NAME";
            // 
            // aNHToolStripMenuItem
            // 
            this.aNHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIRSTNAMEToolStripMenuItem});
            this.aNHToolStripMenuItem.Name = "aNHToolStripMenuItem";
            this.aNHToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aNHToolStripMenuItem.Text = "ANH";
            // 
            // fIRSTNAMEToolStripMenuItem
            // 
            this.fIRSTNAMEToolStripMenuItem.Name = "fIRSTNAMEToolStripMenuItem";
            this.fIRSTNAMEToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.fIRSTNAMEToolStripMenuItem.Text = "FIRST NAME";
            // 
            // tEDToolStripMenuItem
            // 
            this.tEDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fORFOREIGNSPEAKERSToolStripMenuItem});
            this.tEDToolStripMenuItem.Name = "tEDToolStripMenuItem";
            this.tEDToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.tEDToolStripMenuItem.Text = "TED";
            // 
            // fORFOREIGNSPEAKERSToolStripMenuItem
            // 
            this.fORFOREIGNSPEAKERSToolStripMenuItem.Name = "fORFOREIGNSPEAKERSToolStripMenuItem";
            this.fORFOREIGNSPEAKERSToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.fORFOREIGNSPEAKERSToolStripMenuItem.Text = "FOR FOREIGN SPEAKERS";
            // 
            // TrbContribution
            // 
            this.TrbContribution.LargeChange = 1;
            this.TrbContribution.Location = new System.Drawing.Point(26, 143);
            this.TrbContribution.Maximum = 12;
            this.TrbContribution.Name = "TrbContribution";
            this.TrbContribution.Size = new System.Drawing.Size(496, 45);
            this.TrbContribution.TabIndex = 5;
            this.TrbContribution.Scroll += new System.EventHandler(this.TrbContribution_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "12%";
            // 
            // LblContribution
            // 
            this.LblContribution.AutoSize = true;
            this.LblContribution.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblContribution.Location = new System.Drawing.Point(260, 191);
            this.LblContribution.Name = "LblContribution";
            this.LblContribution.Size = new System.Drawing.Size(34, 23);
            this.LblContribution.TabIndex = 8;
            this.LblContribution.Text = "0%";
            // 
            // GrbTaxes
            // 
            this.GrbTaxes.Controls.Add(this.ChkProvincial);
            this.GrbTaxes.Controls.Add(this.ChkFederal);
            this.GrbTaxes.ForeColor = System.Drawing.Color.DarkOrange;
            this.GrbTaxes.Location = new System.Drawing.Point(26, 259);
            this.GrbTaxes.Name = "GrbTaxes";
            this.GrbTaxes.Size = new System.Drawing.Size(496, 91);
            this.GrbTaxes.TabIndex = 9;
            this.GrbTaxes.TabStop = false;
            this.GrbTaxes.Text = "TAXES";
            // 
            // ChkProvincial
            // 
            this.ChkProvincial.AutoSize = true;
            this.ChkProvincial.Checked = true;
            this.ChkProvincial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkProvincial.Enabled = false;
            this.ChkProvincial.Location = new System.Drawing.Point(298, 41);
            this.ChkProvincial.Name = "ChkProvincial";
            this.ChkProvincial.Size = new System.Drawing.Size(125, 25);
            this.ChkProvincial.TabIndex = 1;
            this.ChkProvincial.Text = "Provincial 9%";
            this.ChkProvincial.UseVisualStyleBackColor = true;
            // 
            // ChkFederal
            // 
            this.ChkFederal.AutoSize = true;
            this.ChkFederal.Checked = true;
            this.ChkFederal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFederal.Enabled = false;
            this.ChkFederal.Location = new System.Drawing.Point(48, 41);
            this.ChkFederal.Name = "ChkFederal";
            this.ChkFederal.Size = new System.Drawing.Size(115, 25);
            this.ChkFederal.TabIndex = 0;
            this.ChkFederal.Text = "Federal 18%";
            this.ChkFederal.UseVisualStyleBackColor = true;
            // 
            // GrbInsurance
            // 
            this.GrbInsurance.Controls.Add(this.ChkFamily);
            this.GrbInsurance.Controls.Add(this.ChkIndividual);
            this.GrbInsurance.Controls.Add(this.ChkNone);
            this.GrbInsurance.ForeColor = System.Drawing.Color.DarkOrange;
            this.GrbInsurance.Location = new System.Drawing.Point(26, 389);
            this.GrbInsurance.Name = "GrbInsurance";
            this.GrbInsurance.Size = new System.Drawing.Size(496, 173);
            this.GrbInsurance.TabIndex = 10;
            this.GrbInsurance.TabStop = false;
            this.GrbInsurance.Text = "INSURANCE PLANS";
            // 
            // ChkFamily
            // 
            this.ChkFamily.AutoSize = true;
            this.ChkFamily.Location = new System.Drawing.Point(40, 121);
            this.ChkFamily.Name = "ChkFamily";
            this.ChkFamily.Size = new System.Drawing.Size(73, 25);
            this.ChkFamily.TabIndex = 2;
            this.ChkFamily.TabStop = true;
            this.ChkFamily.Text = "Family";
            this.ChkFamily.UseVisualStyleBackColor = true;
            this.ChkFamily.CheckedChanged += new System.EventHandler(this.ChkFamily_CheckedChanged);
            // 
            // ChkIndividual
            // 
            this.ChkIndividual.AutoSize = true;
            this.ChkIndividual.Location = new System.Drawing.Point(41, 81);
            this.ChkIndividual.Name = "ChkIndividual";
            this.ChkIndividual.Size = new System.Drawing.Size(99, 25);
            this.ChkIndividual.TabIndex = 1;
            this.ChkIndividual.TabStop = true;
            this.ChkIndividual.Text = "Individual";
            this.ChkIndividual.UseVisualStyleBackColor = true;
            this.ChkIndividual.CheckedChanged += new System.EventHandler(this.ChkIndividual_CheckedChanged);
            // 
            // ChkNone
            // 
            this.ChkNone.AutoSize = true;
            this.ChkNone.Location = new System.Drawing.Point(41, 41);
            this.ChkNone.Name = "ChkNone";
            this.ChkNone.Size = new System.Drawing.Size(68, 25);
            this.ChkNone.TabIndex = 0;
            this.ChkNone.TabStop = true;
            this.ChkNone.Text = "None";
            this.ChkNone.UseVisualStyleBackColor = true;
            this.ChkNone.CheckedChanged += new System.EventHandler(this.ChkNone_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(558, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "BI-WEEKLY TAKE HOME PAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPay
            // 
            this.LblPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblPay.Location = new System.Drawing.Point(562, 309);
            this.LblPay.Name = "LblPay";
            this.LblPay.Size = new System.Drawing.Size(423, 45);
            this.LblPay.TabIndex = 12;
            this.LblPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNetpay
            // 
            this.LblNetpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblNetpay.Location = new System.Drawing.Point(562, 167);
            this.LblNetpay.Name = "LblNetpay";
            this.LblNetpay.Size = new System.Drawing.Size(423, 45);
            this.LblNetpay.TabIndex = 14;
            this.LblNetpay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(558, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(427, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "NET PAY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmExam2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1086, 579);
            this.Controls.Add(this.LblNetpay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrbInsurance);
            this.Controls.Add(this.GrbTaxes);
            this.Controls.Add(this.LblContribution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TrbContribution);
            this.Controls.Add(this.Label_Contribution);
            this.Controls.Add(this.NudSalary);
            this.Controls.Add(this.Label_Yearly_Salary);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmExam2";
            this.Text = "Smoke weed with payroll";
            ((System.ComponentModel.ISupportInitialize)(this.NudSalary)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbContribution)).EndInit();
            this.GrbTaxes.ResumeLayout(false);
            this.GrbTaxes.PerformLayout();
            this.GrbInsurance.ResumeLayout(false);
            this.GrbInsurance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Yearly_Salary;
        private System.Windows.Forms.NumericUpDown NudSalary;
        private System.Windows.Forms.Label Label_Contribution;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nGUYENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAMILYNAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hOANGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mIDDLENAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIRSTNAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tEDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORFOREIGNSPEAKERSToolStripMenuItem;
        private System.Windows.Forms.TrackBar TrbContribution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblContribution;
        private System.Windows.Forms.GroupBox GrbTaxes;
        private System.Windows.Forms.CheckBox ChkProvincial;
        private System.Windows.Forms.CheckBox ChkFederal;
        private System.Windows.Forms.GroupBox GrbInsurance;
        private System.Windows.Forms.RadioButton ChkFamily;
        private System.Windows.Forms.RadioButton ChkIndividual;
        private System.Windows.Forms.RadioButton ChkNone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblPay;
        private System.Windows.Forms.Label LblNetpay;
        private System.Windows.Forms.Label label5;
    }
}


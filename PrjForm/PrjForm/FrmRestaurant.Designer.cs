namespace PrjForm
{
    partial class FrmRestaurant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRestaurant));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GrbCPUNVidia = new System.Windows.Forms.GroupBox();
            this.ChkCoreX = new System.Windows.Forms.CheckBox();
            this.ChkCoreI5 = new System.Windows.Forms.CheckBox();
            this.ChkCoreI7 = new System.Windows.Forms.CheckBox();
            this.ChkCoreI3 = new System.Windows.Forms.CheckBox();
            this.GrbCPUAMD = new System.Windows.Forms.GroupBox();
            this.RadRyzenTR = new System.Windows.Forms.RadioButton();
            this.RadRyzen3 = new System.Windows.Forms.RadioButton();
            this.RadRyzen7 = new System.Windows.Forms.RadioButton();
            this.RadRyzen5 = new System.Windows.Forms.RadioButton();
            this.GrbGPUNVidia = new System.Windows.Forms.GroupBox();
            this.ChkGTX10Ti = new System.Windows.Forms.CheckBox();
            this.ChkGTX9 = new System.Windows.Forms.CheckBox();
            this.ChkGTX10 = new System.Windows.Forms.CheckBox();
            this.GrbGPUAMD = new System.Windows.Forms.GroupBox();
            this.ChkAMDR7 = new System.Windows.Forms.CheckBox();
            this.ChkAMDHD = new System.Windows.Forms.CheckBox();
            this.ChkAMDR9 = new System.Windows.Forms.CheckBox();
            this.RadRadeon = new System.Windows.Forms.RadioButton();
            this.RadNVidia = new System.Windows.Forms.RadioButton();
            this.GrbRAM = new System.Windows.Forms.GroupBox();
            this.RadRAM8 = new System.Windows.Forms.RadioButton();
            this.RadRAM32 = new System.Windows.Forms.RadioButton();
            this.RadRAM16 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.GrbDelivery = new System.Windows.Forms.GroupBox();
            this.RadBare = new System.Windows.Forms.RadioButton();
            this.RadAss = new System.Windows.Forms.RadioButton();
            this.RadParts = new System.Windows.Forms.RadioButton();
            this.BtnYourName = new System.Windows.Forms.Button();
            this.RadIntel = new System.Windows.Forms.RadioButton();
            this.RadAMD = new System.Windows.Forms.RadioButton();
            this.LblCost = new System.Windows.Forms.Label();
            this.LabelCPU = new System.Windows.Forms.Label();
            this.LabelGPU = new System.Windows.Forms.Label();
            this.LabelRAM = new System.Windows.Forms.Label();
            this.LabelDelivery = new System.Windows.Forms.Label();
            this.LabelTax = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LblCPU = new System.Windows.Forms.Label();
            this.LblGPU = new System.Windows.Forms.Label();
            this.LblRAM = new System.Windows.Forms.Label();
            this.LblDelivery = new System.Windows.Forms.Label();
            this.LblTax = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.PicNvidia = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GrbCPUNVidia.SuspendLayout();
            this.GrbCPUAMD.SuspendLayout();
            this.GrbGPUNVidia.SuspendLayout();
            this.GrbGPUAMD.SuspendLayout();
            this.GrbRAM.SuspendLayout();
            this.GrbDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNvidia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbCPUNVidia
            // 
            this.GrbCPUNVidia.Controls.Add(this.ChkCoreX);
            this.GrbCPUNVidia.Controls.Add(this.ChkCoreI5);
            this.GrbCPUNVidia.Controls.Add(this.ChkCoreI7);
            this.GrbCPUNVidia.Controls.Add(this.ChkCoreI3);
            this.GrbCPUNVidia.ForeColor = System.Drawing.Color.LimeGreen;
            this.GrbCPUNVidia.Location = new System.Drawing.Point(44, 84);
            this.GrbCPUNVidia.Name = "GrbCPUNVidia";
            this.GrbCPUNVidia.Size = new System.Drawing.Size(198, 229);
            this.GrbCPUNVidia.TabIndex = 2;
            this.GrbCPUNVidia.TabStop = false;
            this.GrbCPUNVidia.Text = "CPU";
            // 
            // ChkCoreX
            // 
            this.ChkCoreX.AutoSize = true;
            this.ChkCoreX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkCoreX.Location = new System.Drawing.Point(16, 179);
            this.ChkCoreX.Name = "ChkCoreX";
            this.ChkCoreX.Size = new System.Drawing.Size(124, 25);
            this.ChkCoreX.TabIndex = 11;
            this.ChkCoreX.Text = "Core X $1000";
            this.ChkCoreX.UseVisualStyleBackColor = true;
            this.ChkCoreX.CheckedChanged += new System.EventHandler(this.ChkCoreX_CheckedChanged);
            // 
            // ChkCoreI5
            // 
            this.ChkCoreI5.AutoSize = true;
            this.ChkCoreI5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkCoreI5.Location = new System.Drawing.Point(16, 75);
            this.ChkCoreI5.Name = "ChkCoreI5";
            this.ChkCoreI5.Size = new System.Drawing.Size(121, 25);
            this.ChkCoreI5.TabIndex = 10;
            this.ChkCoreI5.Text = "Core i5 $600";
            this.ChkCoreI5.UseVisualStyleBackColor = true;
            this.ChkCoreI5.CheckedChanged += new System.EventHandler(this.ChkCoreI5_CheckedChanged);
            // 
            // ChkCoreI7
            // 
            this.ChkCoreI7.AutoSize = true;
            this.ChkCoreI7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkCoreI7.Location = new System.Drawing.Point(17, 128);
            this.ChkCoreI7.Name = "ChkCoreI7";
            this.ChkCoreI7.Size = new System.Drawing.Size(121, 25);
            this.ChkCoreI7.TabIndex = 8;
            this.ChkCoreI7.Text = "Core i7 $900";
            this.ChkCoreI7.UseVisualStyleBackColor = true;
            this.ChkCoreI7.CheckedChanged += new System.EventHandler(this.ChkCoreI7_CheckedChanged);
            // 
            // ChkCoreI3
            // 
            this.ChkCoreI3.AutoSize = true;
            this.ChkCoreI3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkCoreI3.Location = new System.Drawing.Point(16, 28);
            this.ChkCoreI3.Name = "ChkCoreI3";
            this.ChkCoreI3.Size = new System.Drawing.Size(121, 25);
            this.ChkCoreI3.TabIndex = 9;
            this.ChkCoreI3.Text = "Core i3 $300";
            this.ChkCoreI3.UseVisualStyleBackColor = true;
            this.ChkCoreI3.CheckedChanged += new System.EventHandler(this.ChkCoreI3_CheckedChanged);
            // 
            // GrbCPUAMD
            // 
            this.GrbCPUAMD.Controls.Add(this.RadRyzenTR);
            this.GrbCPUAMD.Controls.Add(this.RadRyzen3);
            this.GrbCPUAMD.Controls.Add(this.RadRyzen7);
            this.GrbCPUAMD.Controls.Add(this.RadRyzen5);
            this.GrbCPUAMD.ForeColor = System.Drawing.Color.DarkOrange;
            this.GrbCPUAMD.Location = new System.Drawing.Point(276, 84);
            this.GrbCPUAMD.Name = "GrbCPUAMD";
            this.GrbCPUAMD.Size = new System.Drawing.Size(199, 229);
            this.GrbCPUAMD.TabIndex = 3;
            this.GrbCPUAMD.TabStop = false;
            this.GrbCPUAMD.Text = "CPU";
            // 
            // RadRyzenTR
            // 
            this.RadRyzenTR.AutoSize = true;
            this.RadRyzenTR.Location = new System.Drawing.Point(19, 178);
            this.RadRyzenTR.Name = "RadRyzenTR";
            this.RadRyzenTR.Size = new System.Drawing.Size(134, 25);
            this.RadRyzenTR.TabIndex = 4;
            this.RadRyzenTR.TabStop = true;
            this.RadRyzenTR.Text = "Ryzen TR $950";
            this.RadRyzenTR.UseVisualStyleBackColor = true;
            this.RadRyzenTR.CheckedChanged += new System.EventHandler(this.RadRyzenTR_CheckedChanged);
            // 
            // RadRyzen3
            // 
            this.RadRyzen3.AutoSize = true;
            this.RadRyzen3.Location = new System.Drawing.Point(19, 128);
            this.RadRyzen3.Name = "RadRyzen3";
            this.RadRyzen3.Size = new System.Drawing.Size(124, 25);
            this.RadRyzen3.TabIndex = 3;
            this.RadRyzen3.TabStop = true;
            this.RadRyzen3.Text = "Ryzen 3 $300";
            this.RadRyzen3.UseVisualStyleBackColor = true;
            this.RadRyzen3.CheckedChanged += new System.EventHandler(this.RadRyzen3_CheckedChanged);
            // 
            // RadRyzen7
            // 
            this.RadRyzen7.AutoSize = true;
            this.RadRyzen7.Location = new System.Drawing.Point(19, 28);
            this.RadRyzen7.Name = "RadRyzen7";
            this.RadRyzen7.Size = new System.Drawing.Size(124, 25);
            this.RadRyzen7.TabIndex = 2;
            this.RadRyzen7.TabStop = true;
            this.RadRyzen7.Text = "Ryzen 7 $600";
            this.RadRyzen7.UseVisualStyleBackColor = true;
            this.RadRyzen7.CheckedChanged += new System.EventHandler(this.RadRyzen7_CheckedChanged);
            // 
            // RadRyzen5
            // 
            this.RadRyzen5.AutoSize = true;
            this.RadRyzen5.Location = new System.Drawing.Point(19, 78);
            this.RadRyzen5.Name = "RadRyzen5";
            this.RadRyzen5.Size = new System.Drawing.Size(124, 25);
            this.RadRyzen5.TabIndex = 1;
            this.RadRyzen5.TabStop = true;
            this.RadRyzen5.Text = "Ryzen 5 $400";
            this.RadRyzen5.UseVisualStyleBackColor = true;
            this.RadRyzen5.CheckedChanged += new System.EventHandler(this.RadRyzen5_CheckedChanged);
            // 
            // GrbGPUNVidia
            // 
            this.GrbGPUNVidia.Controls.Add(this.ChkGTX10Ti);
            this.GrbGPUNVidia.Controls.Add(this.ChkGTX9);
            this.GrbGPUNVidia.Controls.Add(this.ChkGTX10);
            this.GrbGPUNVidia.ForeColor = System.Drawing.Color.LimeGreen;
            this.GrbGPUNVidia.Location = new System.Drawing.Point(44, 378);
            this.GrbGPUNVidia.Name = "GrbGPUNVidia";
            this.GrbGPUNVidia.Size = new System.Drawing.Size(198, 184);
            this.GrbGPUNVidia.TabIndex = 3;
            this.GrbGPUNVidia.TabStop = false;
            this.GrbGPUNVidia.Text = "GPU";
            // 
            // ChkGTX10Ti
            // 
            this.ChkGTX10Ti.AutoSize = true;
            this.ChkGTX10Ti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkGTX10Ti.Location = new System.Drawing.Point(17, 76);
            this.ChkGTX10Ti.Name = "ChkGTX10Ti";
            this.ChkGTX10Ti.Size = new System.Drawing.Size(135, 25);
            this.ChkGTX10Ti.TabIndex = 7;
            this.ChkGTX10Ti.Text = "GTX 10 Ti $700";
            this.ChkGTX10Ti.UseVisualStyleBackColor = true;
            this.ChkGTX10Ti.CheckedChanged += new System.EventHandler(this.ChkGTX10Ti_CheckedChanged);
            // 
            // ChkGTX9
            // 
            this.ChkGTX9.AutoSize = true;
            this.ChkGTX9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkGTX9.Location = new System.Drawing.Point(16, 129);
            this.ChkGTX9.Name = "ChkGTX9";
            this.ChkGTX9.Size = new System.Drawing.Size(136, 25);
            this.ChkGTX9.TabIndex = 6;
            this.ChkGTX9.Text = "GTX 900 $1200";
            this.ChkGTX9.UseVisualStyleBackColor = true;
            this.ChkGTX9.CheckedChanged += new System.EventHandler(this.ChkGTX9_CheckedChanged);
            // 
            // ChkGTX10
            // 
            this.ChkGTX10.AutoSize = true;
            this.ChkGTX10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ChkGTX10.Location = new System.Drawing.Point(16, 28);
            this.ChkGTX10.Name = "ChkGTX10";
            this.ChkGTX10.Size = new System.Drawing.Size(118, 25);
            this.ChkGTX10.TabIndex = 5;
            this.ChkGTX10.Text = "GTX 10 $600";
            this.ChkGTX10.UseVisualStyleBackColor = true;
            this.ChkGTX10.CheckedChanged += new System.EventHandler(this.ChkGTX10_CheckedChanged);
            // 
            // GrbGPUAMD
            // 
            this.GrbGPUAMD.Controls.Add(this.ChkAMDR7);
            this.GrbGPUAMD.Controls.Add(this.ChkAMDHD);
            this.GrbGPUAMD.Controls.Add(this.ChkAMDR9);
            this.GrbGPUAMD.ForeColor = System.Drawing.Color.DarkOrange;
            this.GrbGPUAMD.Location = new System.Drawing.Point(276, 378);
            this.GrbGPUAMD.Name = "GrbGPUAMD";
            this.GrbGPUAMD.Size = new System.Drawing.Size(199, 184);
            this.GrbGPUAMD.TabIndex = 4;
            this.GrbGPUAMD.TabStop = false;
            this.GrbGPUAMD.Text = "GPU";
            // 
            // ChkAMDR7
            // 
            this.ChkAMDR7.AutoSize = true;
            this.ChkAMDR7.Location = new System.Drawing.Point(19, 75);
            this.ChkAMDR7.Name = "ChkAMDR7";
            this.ChkAMDR7.Size = new System.Drawing.Size(148, 25);
            this.ChkAMDR7.TabIndex = 9;
            this.ChkAMDR7.Text = "Radeon R5 $500";
            this.ChkAMDR7.UseVisualStyleBackColor = true;
            this.ChkAMDR7.CheckedChanged += new System.EventHandler(this.ChkAMDR7_CheckedChanged);
            // 
            // ChkAMDHD
            // 
            this.ChkAMDHD.AutoSize = true;
            this.ChkAMDHD.Location = new System.Drawing.Point(19, 28);
            this.ChkAMDHD.Name = "ChkAMDHD";
            this.ChkAMDHD.Size = new System.Drawing.Size(152, 25);
            this.ChkAMDHD.TabIndex = 10;
            this.ChkAMDHD.Text = "Radeon HD $300";
            this.ChkAMDHD.UseVisualStyleBackColor = true;
            this.ChkAMDHD.CheckedChanged += new System.EventHandler(this.ChkAMDHD_CheckedChanged);
            // 
            // ChkAMDR9
            // 
            this.ChkAMDR9.AutoSize = true;
            this.ChkAMDR9.Location = new System.Drawing.Point(19, 129);
            this.ChkAMDR9.Name = "ChkAMDR9";
            this.ChkAMDR9.Size = new System.Drawing.Size(148, 25);
            this.ChkAMDR9.TabIndex = 8;
            this.ChkAMDR9.Text = "Radeon R7 $800";
            this.ChkAMDR9.UseVisualStyleBackColor = true;
            this.ChkAMDR9.CheckedChanged += new System.EventHandler(this.ChkAMDR9_CheckedChanged);
            // 
            // RadRadeon
            // 
            this.RadRadeon.AutoSize = true;
            this.RadRadeon.ForeColor = System.Drawing.Color.White;
            this.RadRadeon.Location = new System.Drawing.Point(295, 335);
            this.RadRadeon.Name = "RadRadeon";
            this.RadRadeon.Size = new System.Drawing.Size(84, 25);
            this.RadRadeon.TabIndex = 5;
            this.RadRadeon.TabStop = true;
            this.RadRadeon.Text = "Radeon";
            this.RadRadeon.UseVisualStyleBackColor = true;
            this.RadRadeon.CheckedChanged += new System.EventHandler(this.RadRadeon_CheckedChanged);
            // 
            // RadNVidia
            // 
            this.RadNVidia.AutoSize = true;
            this.RadNVidia.ForeColor = System.Drawing.Color.White;
            this.RadNVidia.Location = new System.Drawing.Point(60, 335);
            this.RadNVidia.Name = "RadNVidia";
            this.RadNVidia.Size = new System.Drawing.Size(82, 25);
            this.RadNVidia.TabIndex = 6;
            this.RadNVidia.TabStop = true;
            this.RadNVidia.Text = "NVIDIA";
            this.RadNVidia.UseVisualStyleBackColor = true;
            this.RadNVidia.CheckedChanged += new System.EventHandler(this.RadNVidia_CheckedChanged);
            // 
            // GrbRAM
            // 
            this.GrbRAM.Controls.Add(this.RadRAM8);
            this.GrbRAM.Controls.Add(this.RadRAM32);
            this.GrbRAM.Controls.Add(this.RadRAM16);
            this.GrbRAM.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.GrbRAM.Location = new System.Drawing.Point(497, 84);
            this.GrbRAM.Name = "GrbRAM";
            this.GrbRAM.Size = new System.Drawing.Size(307, 229);
            this.GrbRAM.TabIndex = 7;
            this.GrbRAM.TabStop = false;
            this.GrbRAM.Text = "RAM";
            // 
            // RadRAM8
            // 
            this.RadRAM8.AutoSize = true;
            this.RadRAM8.Location = new System.Drawing.Point(17, 128);
            this.RadRAM8.Name = "RadRAM8";
            this.RadRAM8.Size = new System.Drawing.Size(211, 25);
            this.RadRAM8.TabIndex = 7;
            this.RadRAM8.TabStop = true;
            this.RadRAM8.Text = "8GB DDR3 1333MHz $100";
            this.RadRAM8.UseVisualStyleBackColor = true;
            this.RadRAM8.CheckedChanged += new System.EventHandler(this.RadRAM8_CheckedChanged);
            // 
            // RadRAM32
            // 
            this.RadRAM32.AutoSize = true;
            this.RadRAM32.Location = new System.Drawing.Point(17, 25);
            this.RadRAM32.Name = "RadRAM32";
            this.RadRAM32.Size = new System.Drawing.Size(223, 25);
            this.RadRAM32.TabIndex = 6;
            this.RadRAM32.TabStop = true;
            this.RadRAM32.Text = "32GB DDR3 1600MHz $200";
            this.RadRAM32.UseVisualStyleBackColor = true;
            this.RadRAM32.CheckedChanged += new System.EventHandler(this.RadRAM32_CheckedChanged);
            // 
            // RadRAM16
            // 
            this.RadRAM16.AutoSize = true;
            this.RadRAM16.Location = new System.Drawing.Point(17, 75);
            this.RadRAM16.Name = "RadRAM16";
            this.RadRAM16.Size = new System.Drawing.Size(217, 25);
            this.RadRAM16.TabIndex = 5;
            this.RadRAM16.TabStop = true;
            this.RadRAM16.Text = "16GB DDR3 1600MHz $150";
            this.RadRAM16.UseVisualStyleBackColor = true;
            this.RadRAM16.CheckedChanged += new System.EventHandler(this.RadRAM16_CheckedChanged);
            // 
            // GrbDelivery
            // 
            this.GrbDelivery.Controls.Add(this.RadBare);
            this.GrbDelivery.Controls.Add(this.RadAss);
            this.GrbDelivery.Controls.Add(this.RadParts);
            this.GrbDelivery.ForeColor = System.Drawing.Color.Aqua;
            this.GrbDelivery.Location = new System.Drawing.Point(497, 378);
            this.GrbDelivery.Name = "GrbDelivery";
            this.GrbDelivery.Size = new System.Drawing.Size(307, 184);
            this.GrbDelivery.TabIndex = 8;
            this.GrbDelivery.TabStop = false;
            this.GrbDelivery.Text = "DELIVERY OPTION";
            this.GrbDelivery.Enter += new System.EventHandler(this.GrbDelivery_Enter);
            // 
            // RadBare
            // 
            this.RadBare.AutoSize = true;
            this.RadBare.Location = new System.Drawing.Point(17, 128);
            this.RadBare.Name = "RadBare";
            this.RadBare.Size = new System.Drawing.Size(121, 25);
            this.RadBare.TabIndex = 7;
            this.RadBare.TabStop = true;
            this.RadBare.Text = "Barebone $0";
            this.RadBare.UseVisualStyleBackColor = true;
            this.RadBare.CheckedChanged += new System.EventHandler(this.RadBare_CheckedChanged);
            // 
            // RadAss
            // 
            this.RadAss.AutoSize = true;
            this.RadAss.Location = new System.Drawing.Point(17, 25);
            this.RadAss.Name = "RadAss";
            this.RadAss.Size = new System.Drawing.Size(137, 25);
            this.RadAss.TabIndex = 6;
            this.RadAss.TabStop = true;
            this.RadAss.Text = "Assembled $10";
            this.RadAss.UseVisualStyleBackColor = true;
            this.RadAss.CheckedChanged += new System.EventHandler(this.RadAss_CheckedChanged);
            // 
            // RadParts
            // 
            this.RadParts.AutoSize = true;
            this.RadParts.Location = new System.Drawing.Point(17, 75);
            this.RadParts.Name = "RadParts";
            this.RadParts.Size = new System.Drawing.Size(86, 25);
            this.RadParts.TabIndex = 5;
            this.RadParts.TabStop = true;
            this.RadParts.Text = "Parts $5";
            this.RadParts.UseVisualStyleBackColor = true;
            this.RadParts.CheckedChanged += new System.EventHandler(this.RadParts_CheckedChanged);
            // 
            // BtnYourName
            // 
            this.BtnYourName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnYourName.ForeColor = System.Drawing.Color.Azure;
            this.BtnYourName.Location = new System.Drawing.Point(894, 18);
            this.BtnYourName.Name = "BtnYourName";
            this.BtnYourName.Size = new System.Drawing.Size(169, 38);
            this.BtnYourName.TabIndex = 9;
            this.BtnYourName.Text = "KIMI NO NA WA";
            this.BtnYourName.UseVisualStyleBackColor = false;
            // 
            // RadIntel
            // 
            this.RadIntel.AutoSize = true;
            this.RadIntel.ForeColor = System.Drawing.Color.White;
            this.RadIntel.Location = new System.Drawing.Point(60, 25);
            this.RadIntel.Name = "RadIntel";
            this.RadIntel.Size = new System.Drawing.Size(133, 25);
            this.RadIntel.TabIndex = 10;
            this.RadIntel.TabStop = true;
            this.RadIntel.Text = "INTEL SYSTEM";
            this.RadIntel.UseVisualStyleBackColor = true;
            this.RadIntel.CheckedChanged += new System.EventHandler(this.RadIntel_CheckedChanged);
            // 
            // RadAMD
            // 
            this.RadAMD.AutoSize = true;
            this.RadAMD.ForeColor = System.Drawing.Color.White;
            this.RadAMD.Location = new System.Drawing.Point(295, 25);
            this.RadAMD.Name = "RadAMD";
            this.RadAMD.Size = new System.Drawing.Size(128, 25);
            this.RadAMD.TabIndex = 11;
            this.RadAMD.TabStop = true;
            this.RadAMD.Text = "AMD SYSTEM";
            this.RadAMD.UseVisualStyleBackColor = true;
            this.RadAMD.CheckedChanged += new System.EventHandler(this.RadAMD_CheckedChanged);
            // 
            // LblCost
            // 
            this.LblCost.ForeColor = System.Drawing.Color.White;
            this.LblCost.Location = new System.Drawing.Point(964, 59);
            this.LblCost.Name = "LblCost";
            this.LblCost.Size = new System.Drawing.Size(99, 25);
            this.LblCost.TabIndex = 12;
            this.LblCost.Text = "COST";
            this.LblCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelCPU
            // 
            this.LabelCPU.ForeColor = System.Drawing.Color.Fuchsia;
            this.LabelCPU.Location = new System.Drawing.Point(827, 95);
            this.LabelCPU.Name = "LabelCPU";
            this.LabelCPU.Size = new System.Drawing.Size(99, 25);
            this.LabelCPU.TabIndex = 13;
            this.LabelCPU.Text = "CPU";
            this.LabelCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelGPU
            // 
            this.LabelGPU.ForeColor = System.Drawing.Color.Fuchsia;
            this.LabelGPU.Location = new System.Drawing.Point(827, 131);
            this.LabelGPU.Name = "LabelGPU";
            this.LabelGPU.Size = new System.Drawing.Size(99, 25);
            this.LabelGPU.TabIndex = 14;
            this.LabelGPU.Text = "GPU";
            this.LabelGPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelRAM
            // 
            this.LabelRAM.ForeColor = System.Drawing.Color.Fuchsia;
            this.LabelRAM.Location = new System.Drawing.Point(827, 171);
            this.LabelRAM.Name = "LabelRAM";
            this.LabelRAM.Size = new System.Drawing.Size(99, 25);
            this.LabelRAM.TabIndex = 15;
            this.LabelRAM.Text = "RAM";
            this.LabelRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDelivery
            // 
            this.LabelDelivery.ForeColor = System.Drawing.Color.Fuchsia;
            this.LabelDelivery.Location = new System.Drawing.Point(827, 212);
            this.LabelDelivery.Name = "LabelDelivery";
            this.LabelDelivery.Size = new System.Drawing.Size(99, 25);
            this.LabelDelivery.TabIndex = 16;
            this.LabelDelivery.Text = "DELIVERY";
            this.LabelDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTax
            // 
            this.LabelTax.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTax.Location = new System.Drawing.Point(827, 248);
            this.LabelTax.Name = "LabelTax";
            this.LabelTax.Size = new System.Drawing.Size(99, 25);
            this.LabelTax.TabIndex = 17;
            this.LabelTax.Text = "TAX";
            this.LabelTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelTotal
            // 
            this.LabelTotal.ForeColor = System.Drawing.Color.LimeGreen;
            this.LabelTotal.Location = new System.Drawing.Point(827, 288);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(99, 25);
            this.LabelTotal.TabIndex = 18;
            this.LabelTotal.Text = "TOTAL";
            this.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCPU
            // 
            this.LblCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblCPU.Location = new System.Drawing.Point(964, 95);
            this.LblCPU.Name = "LblCPU";
            this.LblCPU.Size = new System.Drawing.Size(99, 25);
            this.LblCPU.TabIndex = 19;
            this.LblCPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCPU.Click += new System.EventHandler(this.LblCPU_Click);
            // 
            // LblGPU
            // 
            this.LblGPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblGPU.Location = new System.Drawing.Point(964, 131);
            this.LblGPU.Name = "LblGPU";
            this.LblGPU.Size = new System.Drawing.Size(99, 25);
            this.LblGPU.TabIndex = 20;
            this.LblGPU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblGPU.Click += new System.EventHandler(this.LblGPU_Click);
            // 
            // LblRAM
            // 
            this.LblRAM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblRAM.Location = new System.Drawing.Point(964, 171);
            this.LblRAM.Name = "LblRAM";
            this.LblRAM.Size = new System.Drawing.Size(99, 25);
            this.LblRAM.TabIndex = 21;
            this.LblRAM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRAM.Click += new System.EventHandler(this.LblRAM_Click);
            // 
            // LblDelivery
            // 
            this.LblDelivery.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblDelivery.Location = new System.Drawing.Point(964, 212);
            this.LblDelivery.Name = "LblDelivery";
            this.LblDelivery.Size = new System.Drawing.Size(99, 25);
            this.LblDelivery.TabIndex = 22;
            this.LblDelivery.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblDelivery.Click += new System.EventHandler(this.LblDelivery_Click);
            // 
            // LblTax
            // 
            this.LblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTax.Location = new System.Drawing.Point(964, 248);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(99, 25);
            this.LblTax.TabIndex = 23;
            this.LblTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTax.Click += new System.EventHandler(this.LblTax_Click);
            // 
            // LblTotal
            // 
            this.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotal.Location = new System.Drawing.Point(964, 288);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(99, 25);
            this.LblTotal.TabIndex = 24;
            this.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // PicNvidia
            // 
            this.PicNvidia.Image = ((System.Drawing.Image)(resources.GetObject("PicNvidia.Image")));
            this.PicNvidia.Location = new System.Drawing.Point(199, 12);
            this.PicNvidia.MaximumSize = new System.Drawing.Size(100, 100);
            this.PicNvidia.Name = "PicNvidia";
            this.PicNvidia.Size = new System.Drawing.Size(61, 59);
            this.PicNvidia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicNvidia.TabIndex = 26;
            this.PicNvidia.TabStop = false;
            this.PicNvidia.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 12);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(100, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.button1.Location = new System.Drawing.Point(964, 330);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 35);
            this.button1.TabIndex = 28;
            this.button1.Text = "CALC";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(964, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 29;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1104, 589);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicNvidia);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblTax);
            this.Controls.Add(this.LblDelivery);
            this.Controls.Add(this.LblRAM);
            this.Controls.Add(this.LblGPU);
            this.Controls.Add(this.LblCPU);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.LabelTax);
            this.Controls.Add(this.LabelDelivery);
            this.Controls.Add(this.LabelRAM);
            this.Controls.Add(this.LabelGPU);
            this.Controls.Add(this.LabelCPU);
            this.Controls.Add(this.LblCost);
            this.Controls.Add(this.RadAMD);
            this.Controls.Add(this.RadIntel);
            this.Controls.Add(this.BtnYourName);
            this.Controls.Add(this.GrbDelivery);
            this.Controls.Add(this.GrbRAM);
            this.Controls.Add(this.RadNVidia);
            this.Controls.Add(this.RadRadeon);
            this.Controls.Add(this.GrbGPUAMD);
            this.Controls.Add(this.GrbGPUNVidia);
            this.Controls.Add(this.GrbCPUAMD);
            this.Controls.Add(this.GrbCPUNVidia);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRestaurant";
            this.Text = "CPU BUILDER";
            this.GrbCPUNVidia.ResumeLayout(false);
            this.GrbCPUNVidia.PerformLayout();
            this.GrbCPUAMD.ResumeLayout(false);
            this.GrbCPUAMD.PerformLayout();
            this.GrbGPUNVidia.ResumeLayout(false);
            this.GrbGPUNVidia.PerformLayout();
            this.GrbGPUAMD.ResumeLayout(false);
            this.GrbGPUAMD.PerformLayout();
            this.GrbRAM.ResumeLayout(false);
            this.GrbRAM.PerformLayout();
            this.GrbDelivery.ResumeLayout(false);
            this.GrbDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicNvidia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GrbCPUNVidia;
        private System.Windows.Forms.GroupBox GrbCPUAMD;
        private System.Windows.Forms.RadioButton RadRyzen3;
        private System.Windows.Forms.RadioButton RadRyzen7;
        private System.Windows.Forms.RadioButton RadRyzen5;
        private System.Windows.Forms.GroupBox GrbGPUNVidia;
        private System.Windows.Forms.GroupBox GrbGPUAMD;
        private System.Windows.Forms.CheckBox ChkGTX10Ti;
        private System.Windows.Forms.CheckBox ChkGTX9;
        private System.Windows.Forms.CheckBox ChkGTX10;
        private System.Windows.Forms.CheckBox ChkAMDHD;
        private System.Windows.Forms.CheckBox ChkAMDR9;
        private System.Windows.Forms.CheckBox ChkAMDR7;
        private System.Windows.Forms.RadioButton RadRyzenTR;
        private System.Windows.Forms.RadioButton RadRadeon;
        private System.Windows.Forms.RadioButton RadNVidia;
        private System.Windows.Forms.CheckBox ChkCoreX;
        private System.Windows.Forms.CheckBox ChkCoreI5;
        private System.Windows.Forms.CheckBox ChkCoreI7;
        private System.Windows.Forms.CheckBox ChkCoreI3;
        private System.Windows.Forms.GroupBox GrbRAM;
        private System.Windows.Forms.RadioButton RadRAM8;
        private System.Windows.Forms.RadioButton RadRAM32;
        private System.Windows.Forms.RadioButton RadRAM16;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox GrbDelivery;
        private System.Windows.Forms.RadioButton RadBare;
        private System.Windows.Forms.RadioButton RadAss;
        private System.Windows.Forms.RadioButton RadParts;
        private System.Windows.Forms.Button BtnYourName;
        private System.Windows.Forms.RadioButton RadIntel;
        private System.Windows.Forms.RadioButton RadAMD;
        private System.Windows.Forms.Label LblCost;
        private System.Windows.Forms.Label LabelCPU;
        private System.Windows.Forms.Label LabelGPU;
        private System.Windows.Forms.Label LabelRAM;
        private System.Windows.Forms.Label LabelDelivery;
        private System.Windows.Forms.Label LabelTax;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LblCPU;
        private System.Windows.Forms.Label LblGPU;
        private System.Windows.Forms.Label LblRAM;
        private System.Windows.Forms.Label LblDelivery;
        private System.Windows.Forms.Label LblTax;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.PictureBox PicNvidia;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
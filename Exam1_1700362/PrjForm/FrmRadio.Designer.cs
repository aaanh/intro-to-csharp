namespace PrjForm
{
    partial class FrmRadio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRadio));
            this.GrbGender = new System.Windows.Forms.GroupBox();
            this.PicWoman = new System.Windows.Forms.PictureBox();
            this.PicLibtards = new System.Windows.Forms.PictureBox();
            this.PicMan = new System.Windows.Forms.PictureBox();
            this.LblQuery = new System.Windows.Forms.Label();
            this.RadFemale = new System.Windows.Forms.RadioButton();
            this.RadMale = new System.Windows.Forms.RadioButton();
            this.RadOther = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.GrbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLibtards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMan)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbGender
            // 
            this.GrbGender.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.GrbGender.Controls.Add(this.button2);
            this.GrbGender.Controls.Add(this.PicWoman);
            this.GrbGender.Controls.Add(this.PicLibtards);
            this.GrbGender.Controls.Add(this.PicMan);
            this.GrbGender.Controls.Add(this.LblQuery);
            this.GrbGender.Controls.Add(this.RadFemale);
            this.GrbGender.Controls.Add(this.RadMale);
            this.GrbGender.Controls.Add(this.RadOther);
            this.GrbGender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbGender.ForeColor = System.Drawing.Color.White;
            this.GrbGender.Location = new System.Drawing.Point(13, 14);
            this.GrbGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrbGender.Name = "GrbGender";
            this.GrbGender.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrbGender.Size = new System.Drawing.Size(691, 337);
            this.GrbGender.TabIndex = 0;
            this.GrbGender.TabStop = false;
            this.GrbGender.Text = "Gender";
            // 
            // PicWoman
            // 
            this.PicWoman.Image = ((System.Drawing.Image)(resources.GetObject("PicWoman.Image")));
            this.PicWoman.Location = new System.Drawing.Point(135, 154);
            this.PicWoman.MaximumSize = new System.Drawing.Size(100, 100);
            this.PicWoman.Name = "PicWoman";
            this.PicWoman.Size = new System.Drawing.Size(61, 59);
            this.PicWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicWoman.TabIndex = 7;
            this.PicWoman.TabStop = false;
            this.PicWoman.Visible = false;
            this.PicWoman.Click += new System.EventHandler(this.PicWoman_Click);
            // 
            // PicLibtards
            // 
            this.PicLibtards.Image = ((System.Drawing.Image)(resources.GetObject("PicLibtards.Image")));
            this.PicLibtards.Location = new System.Drawing.Point(136, 237);
            this.PicLibtards.MaximumSize = new System.Drawing.Size(100, 100);
            this.PicLibtards.Name = "PicLibtards";
            this.PicLibtards.Size = new System.Drawing.Size(61, 59);
            this.PicLibtards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLibtards.TabIndex = 6;
            this.PicLibtards.TabStop = false;
            this.PicLibtards.Visible = false;
            // 
            // PicMan
            // 
            this.PicMan.Image = ((System.Drawing.Image)(resources.GetObject("PicMan.Image")));
            this.PicMan.Location = new System.Drawing.Point(136, 77);
            this.PicMan.MaximumSize = new System.Drawing.Size(100, 100);
            this.PicMan.Name = "PicMan";
            this.PicMan.Size = new System.Drawing.Size(61, 59);
            this.PicMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMan.TabIndex = 4;
            this.PicMan.TabStop = false;
            this.PicMan.Visible = false;
            // 
            // LblQuery
            // 
            this.LblQuery.AutoSize = true;
            this.LblQuery.Location = new System.Drawing.Point(22, 42);
            this.LblQuery.Name = "LblQuery";
            this.LblQuery.Size = new System.Drawing.Size(165, 21);
            this.LblQuery.TabIndex = 3;
            this.LblQuery.Text = "Choose your poison:";
            this.LblQuery.Click += new System.EventHandler(this.label1_Click);
            // 
            // RadFemale
            // 
            this.RadFemale.AutoSize = true;
            this.RadFemale.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadFemale.ForeColor = System.Drawing.Color.White;
            this.RadFemale.Location = new System.Drawing.Point(26, 167);
            this.RadFemale.Name = "RadFemale";
            this.RadFemale.Size = new System.Drawing.Size(80, 25);
            this.RadFemale.TabIndex = 2;
            this.RadFemale.TabStop = true;
            this.RadFemale.Text = "Female";
            this.RadFemale.UseVisualStyleBackColor = true;
            this.RadFemale.CheckedChanged += new System.EventHandler(this.RadFemale_CheckedChanged);
            // 
            // RadMale
            // 
            this.RadMale.AutoSize = true;
            this.RadMale.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadMale.ForeColor = System.Drawing.Color.White;
            this.RadMale.Location = new System.Drawing.Point(26, 90);
            this.RadMale.Name = "RadMale";
            this.RadMale.Size = new System.Drawing.Size(64, 25);
            this.RadMale.TabIndex = 1;
            this.RadMale.TabStop = true;
            this.RadMale.Text = "Male";
            this.RadMale.UseVisualStyleBackColor = true;
            this.RadMale.CheckedChanged += new System.EventHandler(this.RadMale_CheckedChanged);
            // 
            // RadOther
            // 
            this.RadOther.AutoSize = true;
            this.RadOther.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadOther.ForeColor = System.Drawing.Color.White;
            this.RadOther.Location = new System.Drawing.Point(26, 254);
            this.RadOther.Name = "RadOther";
            this.RadOther.Size = new System.Drawing.Size(70, 25);
            this.RadOther.TabIndex = 0;
            this.RadOther.TabStop = true;
            this.RadOther.Text = "Other";
            this.RadOther.UseVisualStyleBackColor = true;
            this.RadOther.CheckedChanged += new System.EventHandler(this.RadOther_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(571, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 38);
            this.button2.TabIndex = 30;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(720, 379);
            this.Controls.Add(this.GrbGender);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRadio";
            this.Text = "FrmRadio";
            this.GrbGender.ResumeLayout(false);
            this.GrbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLibtards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbGender;
        private System.Windows.Forms.Label LblQuery;
        private System.Windows.Forms.RadioButton RadFemale;
        private System.Windows.Forms.RadioButton RadMale;
        private System.Windows.Forms.RadioButton RadOther;
        private System.Windows.Forms.PictureBox PicWoman;
        private System.Windows.Forms.PictureBox PicLibtards;
        private System.Windows.Forms.PictureBox PicMan;
        private System.Windows.Forms.Button button2;
    }
}
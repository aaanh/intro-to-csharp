namespace PrjForm
{
    partial class FrmDropdown
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
            this.PnlDrop = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuF = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuF_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuF_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuF_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.colorCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuC_Form = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuC_Panel = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PnlDrop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDrop
            // 
            this.PnlDrop.Controls.Add(this.menuStrip1);
            this.PnlDrop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDrop.Location = new System.Drawing.Point(0, 0);
            this.PnlDrop.Name = "PnlDrop";
            this.PnlDrop.Size = new System.Drawing.Size(1129, 611);
            this.PnlDrop.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuF,
            this.colorCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1129, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "some menu";
            // 
            // MnuF
            // 
            this.MnuF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuF_Save,
            this.MnuF_Open,
            this.MnuF_Print});
            this.MnuF.ForeColor = System.Drawing.Color.Maroon;
            this.MnuF.Name = "MnuF";
            this.MnuF.Size = new System.Drawing.Size(54, 20);
            this.MnuF.Text = "File (F)";
            // 
            // MnuF_Save
            // 
            this.MnuF_Save.Name = "MnuF_Save";
            this.MnuF_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.MnuF_Save.Size = new System.Drawing.Size(152, 22);
            this.MnuF_Save.Text = "&Save";
            // 
            // MnuF_Open
            // 
            this.MnuF_Open.Name = "MnuF_Open";
            this.MnuF_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MnuF_Open.Size = new System.Drawing.Size(152, 22);
            this.MnuF_Open.Text = "&Open";
            // 
            // MnuF_Print
            // 
            this.MnuF_Print.Name = "MnuF_Print";
            this.MnuF_Print.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.MnuF_Print.Size = new System.Drawing.Size(152, 22);
            this.MnuF_Print.Text = "&Print";
            // 
            // colorCToolStripMenuItem
            // 
            this.colorCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuC_Form,
            this.toolStripSeparator1,
            this.MnuC_Panel});
            this.colorCToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.colorCToolStripMenuItem.Name = "colorCToolStripMenuItem";
            this.colorCToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.colorCToolStripMenuItem.Text = "Color (C)";
            // 
            // MnuC_Form
            // 
            this.MnuC_Form.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.MnuC_Form.Name = "MnuC_Form";
            this.MnuC_Form.Size = new System.Drawing.Size(152, 22);
            this.MnuC_Form.Text = "Form";
            this.MnuC_Form.Click += new System.EventHandler(this.formToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.redToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redToolStripMenuItem.Text = "&Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem.Text = "&Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blueToolStripMenuItem.Text = "&Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // MnuC_Panel
            // 
            this.MnuC_Panel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purpleToolStripMenuItem,
            this.cyanToolStripMenuItem,
            this.magentaToolStripMenuItem});
            this.MnuC_Panel.Name = "MnuC_Panel";
            this.MnuC_Panel.Size = new System.Drawing.Size(152, 22);
            this.MnuC_Panel.Text = "Panel";
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.purpleToolStripMenuItem.Text = "&Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.cyanToolStripMenuItem.Text = "&Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.cyanToolStripMenuItem_Click);
            // 
            // magentaToolStripMenuItem
            // 
            this.magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            this.magentaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.magentaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.magentaToolStripMenuItem.Text = "&Magenta";
            this.magentaToolStripMenuItem.Click += new System.EventHandler(this.magentaToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // FrmDropdown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1129, 611);
            this.Controls.Add(this.PnlDrop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDropdown";
            this.Text = "FrmDropdown";
            this.PnlDrop.ResumeLayout(false);
            this.PnlDrop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDrop;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuF;
        private System.Windows.Forms.ToolStripMenuItem MnuF_Save;
        private System.Windows.Forms.ToolStripMenuItem MnuF_Open;
        private System.Windows.Forms.ToolStripMenuItem MnuF_Print;
        private System.Windows.Forms.ToolStripMenuItem colorCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuC_Form;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuC_Panel;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
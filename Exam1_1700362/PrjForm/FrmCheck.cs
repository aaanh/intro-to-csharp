using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjForm
{
    public partial class FrmCheck : Form
    {
        public FrmCheck()
        {
            InitializeComponent();
        }

        private void ChkNvidia_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkNvidia111.Checked)
                PicNvidia.Visible = true;
            else PicNvidia.Visible = false;
        }

        private void ChkAMD_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAMD111.Checked)
                PicAMD.Visible = true;
            else PicAMD.Visible = false;
        }

        private void ChkIntel_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkIntel111.Checked)
                PicIntel.Visible = true;
            else PicIntel.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicNvidia_Click(object sender, EventArgs e)
        {

        }
    }
}

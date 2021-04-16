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
    public partial class FrmRadio : Form
    {
        public FrmRadio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RadMale_CheckedChanged(object sender, EventArgs e)
        {
            PicMan.Visible = true;
            
        }

        private void PicWoman_Click(object sender, EventArgs e)
        {

        }

        private void RadFemale_CheckedChanged(object sender, EventArgs e)
        {
            PicWoman.Visible = true;
        }

        private void RadOther_CheckedChanged(object sender, EventArgs e)
        {
            PicLibtards.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

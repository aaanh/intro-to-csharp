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
    public partial class FrmMouseEvents : Form
    {
        public FrmMouseEvents()
        {
            InitializeComponent();
        }

        private void BtnUp_Click(object sender, EventArgs e)
        {
            PicTetris.Top -= 10;
        }

        private void BtnDown_Click(object sender, EventArgs e)
        {
            PicTetris.Top += 10;
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            PicTetris.Left -= 10;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            PicTetris.Left += 10;
        }

        private void PicTetris_Click(object sender, EventArgs e)
        {

        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            PnlAnotherOne.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void PnlAnotherOne_MouseLeave(object sender, EventArgs e)
        {
            PnlAnotherOne.BackColor = System.Drawing.Color.DarkGoldenrod;
        }
    }
}

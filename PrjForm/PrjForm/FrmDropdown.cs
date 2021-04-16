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
    public partial class FrmDropdown : Form
    {
        public FrmDropdown()
        {
            InitializeComponent();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }

        private void cyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Cyan;
        }

        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
        }
    }
}

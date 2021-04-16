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
    public partial class FrmRectangle : Form
    {
        public FrmRectangle()
        {
            InitializeComponent();
        }

        private void LblHeight_Click(object sender, EventArgs e)
        {

        }

        private void LblArea_Click(object sender, EventArgs e)
        {

        }

        private void BtnCLR_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(TxtLength.Text);
            double width = Convert.ToDouble(TxtWidth.Text);
            double area = (length * width);
            LblArea.Text = area.ToString();
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            TxtWidth.Text = "";
            TxtLength.Text = "";
        }

        private void TxtWidth_TextChanged(object sender, EventArgs e)
        {
            BtnEQU.Enabled = true;
            double check;
            if (double.TryParse(TxtWidth.Text, out check))
            {
                TxtWidth.Text = Convert.ToString(check);
                
            }
            else
            {
                MessageBox.Show("You're fucked, idiot.", "CALC", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                TxtWidth.Text = "";
                TxtWidth.Focus();
            }

        }

        private void TxtLength_TextChanged(object sender, EventArgs e)
        {
            BtnEQU.Enabled = true;
            double check;
            if (double.TryParse(TxtLength.Text, out check))
            {
                TxtLength.Text = Convert.ToString(check);
            }
            else
            {
                MessageBox.Show("You're fucked, idiot.", "CALC", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                TxtLength.Text = "";
                TxtLength.Focus();
            }
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're fucked, idiot.", "CALC", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

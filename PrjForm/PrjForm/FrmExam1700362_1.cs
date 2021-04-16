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
    public partial class FrmExam1700362_1 : Form
    {
        double priceburgers = 5, pricefries = 3, pricedrinks = 1;
        double totalpburgers, totalpfries, totalpdrinks;
        double total, subtotal;
        double tax;

        private void ChkFries_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkFries.Checked)
            {
                HscFries.Enabled = true;
                LblQFries.Enabled = true;
                LblPFries.Enabled = true;
            }
            else
            {
                HscFries.Enabled = false;
                LblQFries.Enabled = false;
                LblPFries.Enabled = false;
            }
        }

        private void ChkDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDrinks.Checked)
            {
                HScDrinks.Enabled = true;
                LblQDrinks.Enabled = true;
                LblPDrinks.Enabled = true;
            }
            else
            {
                HScDrinks.Enabled = false;
                LblQDrinks.Enabled = false;
                LblPDrinks.Enabled = false;
            }
        }

        public FrmExam1700362_1()
        {
            InitializeComponent();
        }

        private void HscFries_Scroll(object sender, ScrollEventArgs e)
        {
            LblQFries.Text = Convert.ToString(HscFries.Value);
            LblPFries.Text = Convert.ToString(HscFries.Value * pricefries);
            totalpfries = HscFries.Value * pricefries;
            subtotal = totalpfries + totalpburgers + totalpdrinks;
            tax = (totalpfries + totalpburgers + totalpdrinks) * 0.12;
            total = (totalpfries + totalpburgers + totalpdrinks) + tax;
            LblSub.Text = Convert.ToString(subtotal);
            LblTax.Text = Convert.ToString(tax);
            LblTotal.Text = Convert.ToString(total);
        }

        private void HScDrinks_Scroll(object sender, ScrollEventArgs e)
        {
            LblQDrinks.Text = Convert.ToString(HScDrinks.Value);
            LblPDrinks.Text = Convert.ToString(HScDrinks.Value * pricedrinks);
            totalpdrinks = HScDrinks.Value * pricedrinks;
            subtotal = totalpfries + totalpburgers + totalpdrinks;
            tax = (totalpfries + totalpburgers + totalpdrinks) * 0.12;
            total = (totalpfries + totalpburgers + totalpdrinks) + tax;
            LblSub.Text = Convert.ToString(subtotal);
            LblTax.Text = Convert.ToString(tax);
            LblTotal.Text = Convert.ToString(total);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkBurgers.Checked)
            {
                HScBurgers.Enabled = true;
                LblQBurgers.Enabled = true;
                LblPBurgers.Enabled = true;
            }
            else
            {
                HScBurgers.Enabled = false;
                LblQBurgers.Enabled = false;
                LblPBurgers.Enabled = false;
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            LblQBurgers.Text = Convert.ToString(HScBurgers.Value);
            LblPBurgers.Text = Convert.ToString(HScBurgers.Value * priceburgers);
            totalpburgers = HScBurgers.Value * priceburgers;
            subtotal = totalpfries + totalpburgers + totalpdrinks;
            tax = (totalpfries + totalpburgers + totalpdrinks) * 0.12;
            total = (totalpfries + totalpburgers + totalpdrinks) + tax;
            LblSub.Text = Convert.ToString(subtotal);
            LblTax.Text = Convert.ToString(tax);
            LblTotal.Text = Convert.ToString(total);
        }
    }
}

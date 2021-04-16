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
        double priceburgers = 2.99, pricefries = 1.99, pricedrinks = 1.25;
        double totalpburgers, totalpfries, totalpdrinks;
        double total, subtotal;
        double tax;
        //*****************************************************************
        public void calculation()
        {
            subtotal = totalpfries + totalpburgers + totalpdrinks;
            tax = subtotal * .12;
            total = subtotal + tax;
            LblSub.Text = subtotal.ToString("c");
            LblTax.Text = tax.ToString("c");
            LblTotal.Text = total.ToString("c");
        }
        //***********************************************************************
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
            totalpfries = Convert.ToDouble(HscFries.Value * pricefries);
            LblPFries.Text = Convert.ToString(HscFries.Value * pricefries);
            calculation();
           
        }

        private void HScDrinks_Scroll(object sender, ScrollEventArgs e)
        {
            LblQDrinks.Text = Convert.ToString(HScDrinks.Value);
            LblPDrinks.Text = Convert.ToString(HScDrinks.Value * pricedrinks);
            calculation();
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
            calculation();
          
        }

        private void FrmExam1700362_1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjMenu3
{
    public partial class FrmLoan : Form
    {
        //Variables
        double amount;
        double payment;
        double sumpay;
        double rate;
        int year;

        public FrmLoan()
        {
            InitializeComponent();
        }

        private void HsbRate_Scroll(object sender, ScrollEventArgs e)
        {
            LblRate.Text = Convert.ToString(HsbRate.Value*.1);
            rate = Convert.ToDouble(LblRate.Text);
        }

        private void HsbYear_Scroll(object sender, ScrollEventArgs e)
        {
            LblYear.Text = Convert.ToString(HsbYear.Value);
            year = HsbYear.Value;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            payment = Microsoft.VisualBasic.Financial.Pmt(rate/12/100, year*12, -1*amount, 0, 0);
            LblPayment.Text = Convert.ToString(payment);
        }

        private void NudLoan_ValueChanged(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(NudLoan.Value);
        }

        private void BtnClr_Click(object sender, EventArgs e)
        {
            LblPayment.Text = string.Empty;
            LblRate.Text = string.Empty;
            LblSum.Text = string.Empty;
            LblYear.Text = string.Empty;
        }
    }
}

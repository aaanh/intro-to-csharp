using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjExam2_1700362
{
    public partial class FrmExam2 : Form
    {
        /* HAAAAA! It looks better now and I uploaded to Lea */

        //Declare variables
        double salary = 10000, netpay, insurance = 0, retirement, pay;
        double fedtax, protax;

        private void ChkFamily_CheckedChanged(object sender, EventArgs e)
        {
            calculations();
        }

        private void ChkIndividual_CheckedChanged(object sender, EventArgs e)
        {
            calculations();
        }

        private void ChkNone_CheckedChanged(object sender, EventArgs e)
        {
            calculations();
        }
        /****************************************************************************/

        //Function
        public void calculations()
        {
            //Calcs
            fedtax = (salary - 10000) * 0.18;
            protax = (salary - 10000) * 0.09;
            retirement = (TrbContribution.Value * 0.01) * salary;
            netpay = salary - (fedtax + protax + insurance + retirement);
            salary = Convert.ToDouble(NudSalary.Value);
            pay = netpay / 26;
            //Insurance plans
            if (ChkNone.Checked == true)
                pay = pay + 0;
            else if (ChkIndividual.Checked == true)
                pay = pay - 20;
            else if (ChkFamily.Checked == true)
                pay = pay - 40;
            else
                pay = pay + 0;

            //Display to labels
            LblContribution.Text = Convert.ToString(TrbContribution.Value) + '%';
            LblNetpay.Text = Convert.ToString(netpay);
            LblPay.Text = Convert.ToString(pay);
        }
        /***************************************************************************/

        //Rest of the codes
        public FrmExam2()
        {
            InitializeComponent();
        }

        private void NudSalary_ValueChanged(object sender, EventArgs e)
        {
            NudSalary.Maximum = decimal.MaxValue;
            calculations();
        }

        private void TrbContribution_Scroll(object sender, EventArgs e)
        {
            calculations();
        }
    }
}

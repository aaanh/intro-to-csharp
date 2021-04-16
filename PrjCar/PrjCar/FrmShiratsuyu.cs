using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjCar
{
    public partial class FrmShiratsuyu : Form
    {
        //Variables and constants
        double sub, total, monthly, sum, options, baseprice, tradein, overhaul, pst, gst, month, apr;
        const double freight = 975;
        Int32 flag;


        /*****************************************************/


        public FrmShiratsuyu()
        {
            InitializeComponent();
            
        }
        public void calculations()
        {
            switch (flag)
            {
                case 1:
                    baseprice = 15000;
                    break;
                case 2:
                    baseprice = 20000;
                    break;
                case 3:
                    baseprice = 25000;
                    break;
                case 4:
                    baseprice = 30000;
                    break;
                case 5:
                    baseprice = 40000;
                    break;
                case 6:
                    baseprice = 50000;
                    break;
                default:
                    baseprice = 0;
                    break;
            }
            sub = baseprice - tradein + options + overhaul + freight;
            gst = sub * 0.07;
            pst = sub * 0.08;
            total = sub + pst + gst;
            
            tradein = Convert.ToDouble(NudTradein.Value);
            LblGST.Text = Convert.ToString(string.Format("{0:N2}", gst));
            LblPST.Text = Convert.ToString(string.Format("{0:N2}", pst));
            LblSub.Text = Convert.ToString(string.Format("{0:N2}", sub));
            LblBase.Text = Convert.ToString(string.Format("{0:N2}", baseprice));
            LblOptions.Text = Convert.ToString(string.Format("{0:N2}", options));
            LblTradein.Text = Convert.ToString(string.Format("{0:N2}", tradein));
            LblOverhaul.Text = Convert.ToString(string.Format("{0:N2}", overhaul));
            LblTotal.Text = "TOTAL: " + Convert.ToString(string.Format("{0:N2}", total));
            
        }
        public void chksum()
        {
            sum = Microsoft.VisualBasic.Financial.Pmt(apr, month, -1 * total, 0, 0);
            monthly = total / month;
            LblMonthly.Text = Convert.ToString(string.Format("{0:N2}", monthly));
            LblSum.Text = Convert.ToString(string.Format("{0:N2}", sum));
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayanamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Yuudachi";
            PicBig.Image = PicAyanami.Image;
            flag = 1;
            calculations();
        }

        private void amagiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Shigure";
            PicBig.Image = PicAmagiri.Image;
            flag = 2;
            calculations();
        }

        private void sagiriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Kawakaze";
            PicBig.Image = PicSagiri.Image;
            flag = 3;
            calculations();
        }

        private void akebonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Akebono";
            PicBig.Image = PicAkebono.Image;
            flag = 4;
            calculations();
        }

        private void ushioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Yamakaze";
            PicBig.Image = PicUshio.Image;
            flag = 5;
            calculations();
        }

        private void sazanamiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Harusame";
            PicBig.Image = PicSazanami.Image;
            flag = 6;
            calculations();
        }

        private void ayanamiToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Yuudachi";
            PicBig.Image = PicAmagiri.Image;
            flag = 1;
            calculations();
        }

        private void amagiriToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Shigure";
            PicBig.Image = PicAmagiri.Image;
            flag = 2;
            calculations();
        }

        private void sagiriToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Kawakaze";
            PicBig.Image = PicSagiri.Image;
            flag = 3;
            calculations();
        }

        private void akebonoToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Akebono";
            PicBig.Image = PicAkebono.Image;
            flag = 4;
            calculations();
        }

        private void ushioToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Yamakaze";
            PicBig.Image = PicUshio.Image;
            flag = 5;
            calculations();
        }

        private void sazanamiToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            LbLAyanamiName.Text = "Harusame";
            PicBig.Image = PicSazanami.Image;
            flag = 6;
            calculations();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PicBig.Image = PicAyanami.Image;
            LbLAyanamiName.Text = "Yuudachi";
            flag = 1;
            calculations();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PicBig.Image = PicAmagiri.Image;
            LbLAyanamiName.Text = "Shigure";
            flag = 2;
            calculations();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PicBig.Image = PicSagiri.Image;
            LbLAyanamiName.Text = "Kawakaze";
            flag = 3;
            calculations();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PicBig.Image = PicAkebono.Image;
            LbLAyanamiName.Text = "Shiratsuyu";
            flag = 4;
            calculations();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PicBig.Image = PicUshio.Image;
            LbLAyanamiName.Text = "Yamakaze";
            flag = 5;
            calculations();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PicBig.Image = PicSazanami.Image;
            LbLAyanamiName.Text = "Harusame";
            flag = 6;
            calculations();
        }

        private void pictureBox1_MouseHover(object sneder, EventArgs e)
        {

        }

        private void PicBig_Click(object sender, EventArgs e)
        {

        }

        private void PicBig_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void ChkM_140_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkM_140.Checked == true)
            {
                options += 500;
                calculations();
            }
            else
            {
                options -= 500;
                calculations();
            }
        }

        private void ChkM_155_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkM_155.Checked == true)
            {
                options += 750;
                calculations();
            }
            else
            {
                options -= 750;
                calculations();
            }
        }

        private void ChkS_140_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkS_140.Checked == true)
            {
                options += 400;
                calculations();
            }
            else
            {
                options -= 400;
                calculations();
            }
        }

        private void ChkS_155_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkS_155.Checked == true)
            {
                options += 600;
                calculations();
            }
            else
            {
                options -= 600;
                calculations();
            }

        }

        private void ChkS_203_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkS_203.Checked == true)
            {
                options += 1000;
                calculations();
            }
            else
            {
                options -= 1000;
                calculations();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChkOverhaul.Checked = false;
            ChkM_140.Checked = false;
            ChkM_155.Checked = false;
            ChkM_203.Checked = false;
            ChkS_140.Checked = false;
            ChkS_155.Checked = false;
            ChkS_203.Checked = false;
        }

        private void LblAPR_Click(object sender, EventArgs e)
        {

        }

        private void HscAPR_Scroll(object sender, ScrollEventArgs e)
        {
            apr = Convert.ToDouble(HscAPR.Value)*0.1;
            LblAPR.Text = Convert.ToString(HscAPR.Value*0.1);
            
        }

        private void Rad12_CheckedChanged(object sender, EventArgs e)
        {
            month = 12;
        }

        private void Rad24_CheckedChanged(object sender, EventArgs e)
        {
            month = 24;
        }

        private void Rad36_CheckedChanged(object sender, EventArgs e)
        {
            month = 36;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HscAPR.Value = HscAPR.Minimum;
            Rad12.Checked = false;
            Rad24.Checked = false;
            Rad36.Checked = false;
            Rad48.Checked = false;
            LblAPR.Text = "";
            LblMonthly.Text = "";
            LblSum.Text = "";
        }

        private void Rad48_CheckedChanged(object sender, EventArgs e)
        {
            month = 48;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if ((Rad12.Checked || Rad24.Checked || Rad36.Checked || Rad48.Checked) == false)
            {
                string message = "You did not select a month period";
                string caption = "Error detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }
            else
            {
                chksum();
            }
        }

        private void ChkM_203_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkM_203.Checked == true)
            {
                options += 1200;
                calculations();
            }
            else
            {
                options -= 1200;
                calculations();
            }
        }

        private void NudTradein_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDouble(NudTradein.Value) > baseprice)
            {
                NudTradein.Value = Convert.ToDecimal(baseprice);
            }
            calculations();
        }

        private void RadMain140_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormClass = new FrmClass();
            FormClass.Closed += (s, args) => this.Close();
            FormClass.Show();
        }

        private void ChkOverhaul_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkOverhaul.Checked == true)
            {
                overhaul = 1100;
                
                calculations();
            }
            else
            {
                overhaul = 0;
                
                calculations();
            }
        }
    }
}

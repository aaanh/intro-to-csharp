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
    public partial class FrmMicrowaveCountDown : Form
    {
        //Variables
        string time;
        double counter;
        bool reset;

        public FrmMicrowaveCountDown()
        {
            InitializeComponent();
            LblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            timer2.Start();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
          
            LblTimer.Text += Btn1.Text;
            time = LblTimer.Text;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn2.Text;
            time = LblTimer.Text;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn3.Text;
            time = LblTimer.Text;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn4.Text;
            time = LblTimer.Text;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn5.Text;
            time = LblTimer.Text;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn6.Text;
            time = LblTimer.Text;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn7.Text;
            time = LblTimer.Text;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn8.Text;
            time = LblTimer.Text;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn9.Text;
            time = LblTimer.Text;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            LblTimer.Text += Btn0.Text;
            time = LblTimer.Text;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            counter = Convert.ToDouble(time);
            timer1.Start();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblTimer.Text = "";
 
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void FrmMicrowaveCountDown_Load(object sender, EventArgs e)
        {
            
        }

        private void LblTimer_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter -= 1;
            LblTimer.Text = Convert.ToString(counter);
            if (counter == 0)
            {
                timer1.Stop();
                LblTime.Text = "Time to eat motherfucker";
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}

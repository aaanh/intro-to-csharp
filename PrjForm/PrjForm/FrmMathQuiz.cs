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
    public partial class FrmMathQuiz : Form
    {
        //Time
        int counter;
        //Switch variable
        int switchvariable;
        int switchpoison;
        //RNG function
        Random rnd = new Random();
        //Variables for RNG
        int c1r1, c1r2, c1r3, c1r4, c1r5, c1r6;
        int c2r1, c2r2, c2r3, c2r4, c2r5, c2r6;
        //Variables for Answers
        double a1, a2, a3, a4, a5, a6;

        private void button2_Click(object sender, EventArgs e)
        {
            //Calculation starts
            a1 = c1r1 + c2r1;
            a2 = c1r2 + c2r2;
            a3 = c1r3 + c2r3;
            a4 = c1r4 + c2r4;
            a5 = c1r5 + c2r5;
            a6 = c1r6 + c2r6;

            //Correction starts
            //Checking answers
            //A1
            if (a1 == b1)
                correct++;
            else
                errors++;
            //A2
            if (a2 == b2)
                correct++;
            else
                errors++;
            //A3
            if (a3 == b3)
                correct++;
            else
                errors++;
            //A4
            if (a4 == b4)
                correct++;
            else
                errors++;
            //A5
            if (a5 == b5)
                correct++;
            else
                errors++;
            //A6
            if (a6 == b6)
                correct++;
            else
                errors++;

            //Score calculation
            percentage = (correct / 6) * 100;
            LblErrors.Text = Convert.ToString(errors);
            LblPercentage.Text = Convert.ToString(percentage);
            LblCorrect.Text = Convert.ToString(correct);
        }

        private void TxtA6_TextChanged(object sender, EventArgs e)
        {
            b1 = Convert.ToDouble(TxtA1.Text);
            b2 = Convert.ToDouble(TxtA2.Text);
            b3 = Convert.ToDouble(TxtA3.Text);
            b4 = Convert.ToDouble(TxtA4.Text);
            b5 = Convert.ToDouble(TxtA5.Text);
            b6 = Convert.ToDouble(TxtA6.Text);
        }

        //Variables middleman for Answers
        double b1, b2, b3, b4, b5, b6;
        //Variables for correct and errors and percentage and time
        double correct, errors, percentage, time;
        private void LblTimer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNoob_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void GrbDifficulty_Enter(object sender, EventArgs e)
        {

        }

        public FrmMathQuiz()
        {
            InitializeComponent();
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                LblTimer.Text = counter.ToString();
            }
            else
                Timer.Stop();

        }
        private void BtnStart_Click(object sender, EventArgs e)
        { 
            //Focus cursor
            TxtA1.Focus();

            //Generate math operators
            LblOp1.Text = "+";
            LblOp2.Text = "+";
            LblOp3.Text = "+";
            LblOp4.Text = "+";
            LblOp5.Text = "+";
            LblOp6.Text = "+";

            //Difficulty **CURRENTLY WORKING
            if (BtnNoob.Checked)
            {
                switchvariable = 1;
            }
            else if (BtnNoob2.Checked)
            {
                switchvariable = 2;
            }
            else if (BtnNoob3.Checked)
            {
                switchvariable = 3;
            }
            else
            {
              //  BtnStart.Enabled = false;
            }

            //Poison **OTHER MATH OPERATIONS HAVE NOT BEEN CODED
            if (BtnMultiplication.Checked)
            {
                switchpoison = 1;
            }
            else if (BtnDivision.Checked)
            {
                switchpoison = 2;
            }
            else if (BtnMixed.Checked)
            {
                switchpoison = 3;
            }
            else
            {
                //BtnStart.Enabled = false;
            }

            //Switch Difficulty
            switch (switchvariable)
            {
                case 1:
                    //Timer
                    counter = 90;
                    //Generating first row
                    c1r1 = rnd.Next(0, 30);
                    c1r2 = rnd.Next(0, 20);
                    c1r3 = rnd.Next(0, 30);
                    c1r4 = rnd.Next(0, 20);
                    c1r5 = rnd.Next(0, 30);
                    c1r6 = rnd.Next(0, 20);
                    //Generating second row
                    c2r1 = rnd.Next(0, 30);
                    c2r2 = rnd.Next(0, 20);
                    c2r3 = rnd.Next(0, 40);
                    c2r4 = rnd.Next(0, 50);
                    c2r5 = rnd.Next(0, 10);
                    c2r6 = rnd.Next(0, 20);
                    break;
                case 2:
                    //Timer
                    counter = 120;
                    //Generating first row
                    c1r1 = rnd.Next(0, 200);
                    c1r2 = rnd.Next(0, 300);
                    c1r3 = rnd.Next(0, 400);
                    c1r4 = rnd.Next(0, 500);
                    c1r5 = rnd.Next(0, 150);
                    c1r6 = rnd.Next(0, 202);
                    //Generating second row
                    c2r1 = rnd.Next(0, 396);
                    c2r2 = rnd.Next(0, 245);
                    c2r3 = rnd.Next(0, 490);
                    c2r4 = rnd.Next(0, 523);
                    c2r5 = rnd.Next(0, 114);
                    c2r6 = rnd.Next(0, 321);
                    break;
                case 3:
                    //Timer
                    counter = 180;
                    //Generating first row
                    c1r1 = rnd.Next(-1000, 1000);
                    c1r2 = rnd.Next(-1000, 1000);
                    c1r3 = rnd.Next(-1000, 1000);
                    c1r4 = rnd.Next(-1000, 1000);
                    c1r5 = rnd.Next(-1000, 1000);
                    c1r6 = rnd.Next(-1000, 1000);
                    //Generating second row
                    c2r1 = rnd.Next(-1000, 1000);
                    c2r2 = rnd.Next(-1000, 1000);
                    c2r3 = rnd.Next(-1000, 1000);
                    c2r4 = rnd.Next(-1000, 1000);
                    c2r5 = rnd.Next(-1000, 1000);
                    c2r6 = rnd.Next(-1000, 1000);
                    break;
                default:
                    break;

            }

            // Convert to label string
            LblC1R1.Text = Convert.ToString(c1r1);
            LblC1R2.Text = Convert.ToString(c1r2);
            LblC1R3.Text = Convert.ToString(c1r3);
            LblC1R4.Text = Convert.ToString(c1r4);
            LblC1R5.Text = Convert.ToString(c1r5);
            LblC1R6.Text = Convert.ToString(c1r6);
            LblC2R1.Text = Convert.ToString(c2r1);
            LblC2R2.Text = Convert.ToString(c2r2);
            LblC2R3.Text = Convert.ToString(c2r3);
            LblC2R4.Text = Convert.ToString(c2r4);
            LblC2R5.Text = Convert.ToString(c2r5);
            LblC2R6.Text = Convert.ToString(c2r6);


            //Timer **IS NOT WORKING
            Timer.Tick -= new EventHandler(Timer_Tick);
            Timer.Start();
            LblTimer.Text = Convert.ToString(counter);
            while (counter > 0)
            {
                counter--;
                LblTimer.Text = counter.ToString();
            }
            Timer.Stop();
        }
       
    }

}

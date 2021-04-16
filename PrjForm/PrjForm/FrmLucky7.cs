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
    public partial class FrmLucky7 : Form
    {
        //Variables
        Random rnd = new Random();
        double spins = 0;
        double wins = 0;
        double percent = 0;
        double money = 0;
        public FrmLucky7()
        {
            InitializeComponent();
            
            
        }

        private void LblNo2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSpin_Click(object sender, EventArgs e)
        {
            spins += 1;
            PicSnoop.Visible = false;
            //Randomizing the numbers
            int no1 = rnd.Next(1, 9);
            int no2 = rnd.Next(1, 9);
            int no3 = rnd.Next(1, 9);

            //Checking the numbers
            if (no1 == 7)
            {
                wins += 1;
                percent = (wins / spins)*100;
                PicSnoop.Visible = true;
                money += 50;
            }
            else if (no2 == 7)
            {
                wins += 1;
                percent = (wins / spins)*100;
                PicSnoop.Visible = true;
                money += 50;
            }
            else if (no3 == 7)
            {
                wins += +1;
                percent = (wins / spins) * 100;
                PicSnoop.Visible = true;
                money += 50;
            }
            else
            {
                percent = (wins / spins) * 100;
                
            }
            LblSpins.Text = Convert.ToString(spins);
            LblWin.Text = Convert.ToString(wins);
            LblPercent.Text = Convert.ToString(percent);
            LblNo1.Text = Convert.ToString(no1);
            LblNo2.Text = Convert.ToString(no2);
            LblNo3.Text = Convert.ToString(no3);
            LblMoney.Text = Convert.ToString(money);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelmoneywon_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//*****************************************************************************************************
/* Program written by: NGUYEN, Hoang Anh (Ted) || the Chinese/Japanese/VIETNAMESE/Asian-lookalike guy *
 * ID: 1700362                                                                                        *
 * For: Intro to programming class (complimentary)                                                    *
 * Project: Car(?) Kantai Collection                                                                  *
 * Last edit: October 26, 2017                                                                        *
 *///**************************************************************************************************

 // REFER TO[OFFICIAL] HOANG ANH executable file if there is font error(Installed font is Roboto by Google)

namespace PrjCar
{
    public partial class FrmClass : Form
    {
        public void ShowFormClass()
        {
            this.Hide();
            var FormClass = new FrmClass();
            FormClass.Closed += (s, args) => this.Close();
            FormClass.Show();
        }
        public FrmClass()
        {
            InitializeComponent();
        }

        private void PicAnayami_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormAyanami = new FrmAyanami();
            FormAyanami.Closed += (s, args) => this.Close();
            FormAyanami.Show();
        }

        private void PicYamato_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormYamamoto = new FrmYamatonoBaka();
            FormYamamoto.Closed += (s, args) => this.Close();
            FormYamamoto.Show();
        }

        private void PicShiratsuyu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormShiratsuyu = new FrmShiratsuyu();
            FormShiratsuyu.FormClosed += (s, args) => this.Close();
            FormShiratsuyu.Show();
        }

        private void PicNagara_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormNagara = new FrmNagara();
            FormNagara.FormClosed += (s, args) => this.Close();
            FormNagara.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lblclick_MouseHover(object sender, EventArgs e)
        {
            Lblclick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; 
        }

        private void Lblclick_MouseLeave(object sender, EventArgs e)
        {
            Lblclick.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void Lblclick_Click(object sender, EventArgs e)
        {
            Lblclick.Visible = false;
            PicBlur.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lblclick.Visible = true;
            PicBlur.Visible = true;
        }

        private void PicBlur_Click(object sender, EventArgs e)
        {
            Lblclick.Visible = false;
            PicBlur.Visible = false;
        }

        private void PicFubuki_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var FormFubuki = new FrmFubuki();
            FormFubuki.FormClosed += (s, args) => this.Close();
            FormFubuki.Show();
        }

        private void PicMutsuki_Click(object sender, EventArgs e)
        {
            this.Hide();
            var FormMutsuki = new FrmMutsuki();
            FormMutsuki.FormClosed += (s, args) => this.Close();
            FormMutsuki.Show();
        }
    }
}

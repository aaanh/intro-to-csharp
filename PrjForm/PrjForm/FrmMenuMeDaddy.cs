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
    public partial class FrmMenuMeDaddy : Form
    {
        public FrmMenuMeDaddy()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            FrmCheck FormCheck = new FrmCheck();
            FormCheck.Show();
        }

        private void BtnRectangle_Click(object sender, EventArgs e)
        {
            FrmRectangle FormRectangle = new FrmRectangle();
            FormRectangle.Show();
        }

        private void BtnRadio_Click(object sender, EventArgs e)
        {
            FrmRadio FormRadio = new FrmRadio();
            FormRadio.Show();
        }

        private void BtnBuildPC_Click(object sender, EventArgs e)
        {
            FrmRestaurant FormResto = new FrmRestaurant();
            FormResto.Show();
        }

        private void BtnLucky7_Click(object sender, EventArgs e)
        {
            FrmLucky7 FormLucky7 = new FrmLucky7();
            FormLucky7.Show();
        }

        private void BtnMathQuiz_Click(object sender, EventArgs e)
        {
            FrmMathQuiz FormMathQuiz = new FrmMathQuiz();
            FormMathQuiz.Show();
        }

        private void BtnCatFood_Click(object sender, EventArgs e)
        {
            FrmExam1700362_1 FormKyattoFudo = new FrmExam1700362_1();
            FormKyattoFudo.Show();
        }

        private void BtnStrip_Click(object sender, EventArgs e)
        {
            FrmDropdown FormDropdown = new FrmDropdown();
            FormDropdown.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMicrowaveCountDown FormMicrowave = new FrmMicrowaveCountDown();
            FormMicrowave.Show();
        }
    }
}

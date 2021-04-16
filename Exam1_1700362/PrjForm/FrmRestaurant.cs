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
    public partial class FrmRestaurant : Form
    {
        //--Variables:
        double gpu = 0;
        double cpu = 0;
        double ram = 0;
        double subtotal = 0;
        double total = 0;
        double tax = 0.25;
        double delivery = 0;
        public FrmRestaurant()
        {
            InitializeComponent();
        }

        private void RadNVidia_CheckedChanged(object sender, EventArgs e)
        {
            if (RadNVidia.Checked)
                GrbGPUAMD.Enabled = false;
            else
                GrbGPUAMD.Enabled = true;
        }

        private void RadCoreI7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkGTX9_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGTX9.Checked)
                gpu += 1200;
            else
                gpu -= 1200;
            LblGPU.Text = Convert.ToString(gpu);
        }

        private void RadMac_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void RadIntel_CheckedChanged(object sender, EventArgs e)
        {
            if (RadIntel.Checked)
            {
                GrbCPUAMD.Enabled = false;
                PicNvidia.Visible = true;
            }
            else
            {
                PicNvidia.Visible = false;
                GrbCPUAMD.Enabled = true;
            }
        }

        private void RadAMD_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAMD.Checked)
            {
                GrbCPUNVidia.Enabled = false;
                PicNvidia.Visible = true;
            }
            else
            {
                PicNvidia.Visible = false;
                GrbCPUNVidia.Enabled = true;
            }
        }

        private void RadRadeon_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRadeon.Checked)
                GrbGPUNVidia.Enabled = false;
            else
                GrbGPUNVidia.Enabled = true;
        }

        private void GrbDelivery_Enter(object sender, EventArgs e)
        {

        }

        private void LblCPU_Click(object sender, EventArgs e)
        {
            LblCPU.Text = Convert.ToString(cpu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //--Calculations:
            subtotal = gpu + cpu + ram + delivery;
            total = subtotal + (subtotal) * tax;
            LblTotal.Text = Convert.ToString(total);
            LblTax.Text = Convert.ToString(subtotal*tax);
            // Lbl1 = Convert.ToString(no1)
        }

        private void ChkCoreI7_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCoreI7.Checked)
                cpu += 900;
            else
                cpu -= 900;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkCoreI3_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCoreI3.Checked)
                cpu += 300;
            else
                cpu -= 300;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkCoreI5_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCoreI5.Checked)
                cpu += 600;
            else
                cpu -= 600;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkCoreX_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkCoreX.Checked)
                cpu += 1000;
            else
                cpu -= 1000;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadRyzen7_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRyzen7.Checked)
                cpu += 600;
            else
                cpu -= 600;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadRyzen5_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRyzen5.Checked)
                cpu += 400;
            else
                cpu -= 400;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadRyzen3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRyzen3.Checked)
                cpu += 300;
            else
                cpu -= 300;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadRyzenTR_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRyzenTR.Checked)
                cpu += 950;
            else
                cpu -= 950;
            LblCPU.Text = Convert.ToString(cpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkGTX10_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGTX10.Checked)
                gpu += 600;
            else
                gpu -= 600;
            LblGPU.Text = Convert.ToString(gpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkGTX10Ti_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkGTX10Ti.Checked)
                gpu += 700;
            else
                gpu -= 700;
            LblGPU.Text = Convert.ToString(gpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkAMDHD_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAMDHD.Checked)
                gpu += 300;
            else
                gpu -= 300;
            LblGPU.Text = Convert.ToString(gpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkAMDR7_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAMDR7.Checked)
                gpu += 300;
            else
                gpu -= 300;
            LblGPU.Text = Convert.ToString(gpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void ChkAMDR9_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAMDR9.Checked)
                gpu += 800;
            else
                gpu -= 800;
            LblGPU.Text = Convert.ToString(gpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadRAM32_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRAM32.Checked)
                ram += 200;
            else
                ram -= 200;
            LblRAM.Text = Convert.ToString(ram);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadRAM16_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRAM16.Checked)
                ram += 150;
            else
                ram -= 150;
            LblRAM.Text = Convert.ToString(ram);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadRAM8_CheckedChanged(object sender, EventArgs e)
        {
            if (RadRAM8.Checked)
                ram += 100;
            else
                ram -= 100;
            LblRAM.Text = Convert.ToString(ram);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadAss_CheckedChanged(object sender, EventArgs e)
        {
            if (RadAss.Checked)
                delivery += 10;
            else
                delivery -= 10;
            LblDelivery.Text = Convert.ToString(delivery);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadParts_CheckedChanged(object sender, EventArgs e)
        {
            if (RadParts.Checked)
                delivery += 5;
            else
                delivery -= 5;
            LblDelivery.Text = Convert.ToString(delivery);
            LblTotal.Text = Convert.ToString(total);
        }

        private void RadBare_CheckedChanged(object sender, EventArgs e)
        {
            if (RadBare.Checked)
                delivery += 0;
            else
                delivery -= 0;
            LblDelivery.Text = Convert.ToString(delivery);
            LblTotal.Text = Convert.ToString(total);
        }

        private void LblGPU_Click(object sender, EventArgs e)
        {
            LblGPU.Text = Convert.ToString(gpu);
            LblTotal.Text = Convert.ToString(total);
        }

        private void LblRAM_Click(object sender, EventArgs e)
        {
            LblRAM.Text = Convert.ToString(ram);
            LblTotal.Text = Convert.ToString(total);
        }

        private void LblDelivery_Click(object sender, EventArgs e)
        {
            LblDelivery.Text = Convert.ToString(delivery);
            LblTotal.Text = Convert.ToString(total);
        }

        private void LblTax_Click(object sender, EventArgs e)
        {
            LblTax.Text = Convert.ToString(tax);
            LblTotal.Text = Convert.ToString(total);
        }

        private void LblTotal_Click(object sender, EventArgs e)
        {
            LblTotal.Text = Convert.ToString(total);
        }
        private void LblTotal_TextChanged(object sender, EventArgs e)
        {
            LblTotal.Text = Convert.ToString(total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

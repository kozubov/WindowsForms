using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2_3
{
    public partial class Form1 : Form
    {
        double TOTALMONEY = 0;
        private int counter = 0;
        double cafesumm { get; set; } = 0;
        double totalfuel { get; set; } = 0;
        double alltotal { get; set; } = 0;
        int timercount;

        public Form1()
        {
            InitializeComponent();
            comboBoxFuelType.SelectedIndex = 0;
            textBoxFuelQuantity.TextChanged += TextBoxFuelQuantity_TextChanged;
            buttonSummAll.Click += ButtonSummAll_Click;
        }
        
        private void comboBoxFuelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFuelType.SelectedIndex == 0)
            {
                labelFuelPrice.Text = @"28,74";
            }
            if (comboBoxFuelType.SelectedIndex == 1)
            {
                labelFuelPrice.Text = @"29,54";
            }
            if (comboBoxFuelType.SelectedIndex == 2)
            {
                labelFuelPrice.Text = @"32,75";
            }
            if (comboBoxFuelType.SelectedIndex == 3)
            {
                labelFuelPrice.Text = @"12,80";
            }
            if (comboBoxFuelType.SelectedIndex == 4)
            {
                labelFuelPrice.Text = @"27,24";
            }
        }

        private void radioButtonQuantity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonQuantity.Checked == true)
            {
                textBoxFuelQuantity.ReadOnly = false;
                textBoxFuelSumm.ReadOnly = true;
                groupBoxTotalFuel.Text = "К оплате:";
                labelTotalQorSumm.Text = "грн.";
            }
            if (radioButtonFuelSumm.Checked == true)
            {
                textBoxFuelQuantity.ReadOnly = true;
                textBoxFuelSumm.ReadOnly = false;
                groupBoxTotalFuel.Text = "К выдаче:";
                labelTotalQorSumm.Text = "л.";
            }
        }

        private void TextBoxFuelQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFuelQuantity.Text))
            {
                totalfuel = (Convert.ToDouble(textBoxFuelQuantity.Text) * Convert.ToDouble(labelFuelPrice.Text));
                labelShowTotalFuel.Text = System.Convert.ToString($"{totalfuel:F2}");
            }
        }
        private void textBoxFuelSumm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFuelSumm.Text))
            {
                totalfuel = (Convert.ToDouble(textBoxFuelSumm.Text));
                labelShowTotalFuel.Text = (Convert.ToDouble(textBoxFuelSumm.Text) / Convert.ToDouble(labelFuelPrice.Text)).ToString("F2");
               }
        }

        private void checkBoxHotDog_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDogSumm.ReadOnly = checkBoxHotDog.Checked != true;
        }

        private void checkBoxBurger_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBurgerSumm.ReadOnly = checkBoxBurger.Checked != true;
        }

        private void checkBoxPotFry_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPotatoSumm.ReadOnly = checkBoxPotFry.Checked != true;
        }

        private void checkBoxCola_CheckedChanged(object sender, EventArgs e)
        {
            textBoxColaSumm.ReadOnly = checkBoxCola.Checked != true;
        }

        private void textBoxDogSumm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxDogSumm.Text))
            {
                double hotdog = (Convert.ToDouble(textBoxDogPrice.Text) * Convert.ToDouble(textBoxDogSumm.Text));
                SummCafe(hotdog);
            }
        }

        private void textBoxBurgerSumm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxBurgerSumm.Text))
            {
                double burger = (Convert.ToDouble(textBoxBurgerPrice.Text) * Convert.ToDouble(textBoxBurgerSumm.Text));
                SummCafe(burger);
            }
        }

        private void textBoxPotatoSumm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxPotatoSumm.Text))
            {
                double potato = (Convert.ToDouble(textBoxPotatoPrice.Text) * Convert.ToDouble(textBoxPotatoSumm.Text));
                SummCafe(potato);
            }
        }

        private void textBoxColaSumm_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxColaSumm.Text))
            {
                double cola = (Convert.ToDouble(textBoxColaPrice.Text) * Convert.ToDouble(textBoxColaSumm.Text));
                SummCafe(cola);
            }
        }

        private void SummCafe(double cafe)
        {
            cafesumm += cafe;
            labelTotalCafe.Text = Convert.ToString($"{cafesumm:F2}");
        }
       

        private void ButtonSummAll_Click(object sender, EventArgs e)
        {
            alltotal = totalfuel + cafesumm;
            labelSummAll.Text = alltotal.ToString("F2");
            TOTALMONEY += alltotal;
            counter ++;
            labelClientsShow.Text = $@"{counter} чел.";
            labelTOTALMONEY.Text = TOTALMONEY.ToString("F2") + " грн.";
            labelAvgCheckShow.Text = (TOTALMONEY / counter).ToString("F2") + " грн.";
            timer1.Enabled = true;
            timer1.Start();
            timercount = 0;
        }
        private void Clear()
        {
            labelTotalCafe.Text = "";
            labelShowTotalFuel.Text = "";
            textBoxFuelSumm.Text = "";
            labelSummAll.Text = "";
            textBoxFuelQuantity.Clear();
            textBoxFuelQuantity.Clear();
            textBoxDogSumm.Clear();
            textBoxBurgerSumm.Clear();
            textBoxPotatoSumm.Clear();
            textBoxColaSumm.Clear();
            checkBoxHotDog.Checked = false;
            checkBoxBurger.Checked = false;
            checkBoxPotFry.Checked = false;
            checkBoxCola.Checked = false;
            cafesumm = 0;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timercount++;
            if (timercount == 7)
            {
                var result = MessageBox.Show("Перейти к следующему клиенту?", "Оповещение", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    Clear();
                }
                if (result == DialogResult.No)
                {
                    timercount = 0;
                }
            }
        }

    }
}

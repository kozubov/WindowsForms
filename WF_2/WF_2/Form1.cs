using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Написать программу, которая по введенной дате определяет день
//недели.Результат выводить в текстовое поле (желательно по-русски).

namespace WF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ClearButton.Click += ClearButtonClick;
            Okbutton.Click += OkbuttonClick;
            DataInput.Enter += DataInput_Enter;
        }

        private void DataInput_Enter(object sender, EventArgs e)
        {
            labelError.Visible = false;
            labelOut.Visible = false;
            DataInput.Clear();
            DataOut.Clear();
        }

        private void OkbuttonClick(object sender, EventArgs e)
        {
            try
            {
                var d = DateTime.Parse(DataInput.Text);
                DataOut.Text = d.ToString("dddd");
                labelOut.Visible = true;
                labelOut.Text = d.ToShortDateString() + " - это";
            }
            catch (Exception)
            {
                labelError.Visible = true;
            }
        }

        private void ClearButtonClick(object sender, EventArgs e)
        {
            DataOut.Clear();
            DataInput.Clear();
            labelError.Visible = false;
            labelOut.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

//Написать программу, вычисляющую сколько осталось времени
//до указанной даты(дата вводится с клавиатуры в Edit).
//Предусмотреть возможность выдачи результата в годах, месяцах, днях, минутах,
//секундах (для первых двух вариантов ответ дробный).
//Для переключения между вариантами желательно использовать переключатели (RadioButton).

namespace WF_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonOk.Click += ButtonOk_Click;
            textInput.Enter += TextInput_Enter;
            buttonClear.Click += ButtonClear_Click;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textOut.Clear();
            textInput.Clear();
        }

        private void TextInput_Enter(object sender, EventArgs e)
        {
            textInput.Clear();
            labelInput.ForeColor = Color.Black;
            labelInput.Text = "Введите дату для расчета";
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            try
            {
                var d = DateTime.Parse(textInput.Text);
                if (d > DateTime.Now)
                {
                    TimeSpan data = d - DateTime.Now;
                    if (radioYear.Checked == true)
                    {
                        textOut.Text = (data.TotalDays / 365.25).ToString("F4") + " лет";
                    }
                    if (radioMonth.Checked == true)
                    {
                        double month = (d.Month + d.Year * 12) - (DateTime.Now.Month + DateTime.Now.Year * 12);
                        double daysInEndMonth = (d - d.AddMonths(1)).Days;
                        double months = month + (DateTime.Now.Day - d.Day) / daysInEndMonth;
                        textOut.Text = months.ToString("F4") + " месяцев";
                        // double months = data.TotalDays / 30;
                        //textOut.Text = (data.TotalDays / 30).ToString("F4") + " месяцев";
                    }
                    if (radioDay.Checked == true)
                    {
                        textOut.Text = (data.TotalDays).ToString("### ### ### дней");
                    }
                    if (radioMinute.Checked == true)
                    {
                        textOut.Text = ((int)data.TotalMinutes).ToString("### ### ### минут");
                    }
                    if (radioSecond.Checked == true)
                    {
                        textOut.Text = ((int)data.TotalSeconds).ToString("### ### ### ### секунд");
                    }
                }
                else
                {
                    labelInput.ForeColor = Color.Red;
                    labelInput.Text = "Введена прошедшая дата";
                }
            }
            catch (Exception)
            {
                labelInput.ForeColor = Color.Red;
                labelInput.Text = "Вы ввели не дату";
            }
        }
    }
}

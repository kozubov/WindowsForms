using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Guess;
        }

        private void Guess(object sender, EventArgs e)
        {            
            int countChoice = 1;
            while (true)
            {
                DialogResult choice;
                choice = MessageBox.Show($"Вы загадали число: {new Random().Next(1, 2000)}?", "Попытка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    MessageBox.Show($"Число было угадано за {countChoice:### ###} попыток", "Удача", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    countChoice = 0;
                    choice = MessageBox.Show($"Вы хотите продолжить?", "Выбор", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (choice == DialogResult.No) this.Close();
                }
                countChoice++;
            }
        }
    }
}

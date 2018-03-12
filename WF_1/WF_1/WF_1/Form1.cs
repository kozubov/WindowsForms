using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Вывести на экран свое(краткое!!!) резюме с помощью последовательности
//MessageBox’ов(числом не менее трех). Причем на заголовке
//последнего должно отобразиться среднее число символов на странице
//(общее количество символов в резюме / количество MessageBox’ов).

namespace WF_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += ShowMessageBox;
        }
        private void ShowMessageBox(object sender, EventArgs e)
        {
            string[] array = { "Студент: Козубов Дмитрий Геннадьевич", "Предмет: Windows Forms", "Группа: ПС/РПО/2016/2" };
            int symbols = 0;
            for (int i = 0; i < array.Length; i++)
            {
                symbols += array[i].Length;
                string title = (array.Length - 1 == i) ? $"MessageBox {i + 1}. Среднее: {symbols / array.Length}. Общее: {symbols}. MBoxes: {array.Length}" : $"MessageBox {i + 1}";
                MessageBox.Show(array[i], title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

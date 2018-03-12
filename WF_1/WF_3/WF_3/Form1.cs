using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей 
//области формы. Необходимо создать следующие обработчики:
//■■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка: внутри
//прямоугольника, снаружи, на границе прямоугольника. Если при нажатии левой кнопки мыши была нажата кнопка
//Control (Ctrl), то приложение должно закрываться;
//■■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
//(рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;
//■■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна
//текущие координаты мыши x и y.

namespace WF_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += MyMouseMove;
            this.MouseClick += MyMouseClick;
        }
        private void MyMouseMove(object sender, MouseEventArgs e)
        {
            Text = $"X: {e.X};  Y: {e.Y}";
        }
        private void MyMouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    string text = "";
                    if (ModifierKeys == Keys.Control)
                    {
                        Close();
                    }
                    if ((e.X< 10 || e.X> ClientSize.Width - 10) || (e.Y< 10 || e.Y> ClientSize.Height - 10))
                    {
                        text = "Клик мышки за пределами прямоугольника!";
                    }
                    else if ((e.X == 10 || e.X == ClientSize.Width - 10) || (e.Y == 10 || e.Y == ClientSize.Height - 10))
                    {
                        text = "Клик мышки на границе прямоугольника!";
                    }
                    else
                    {
                        text = "Клик мышки внутри прямоугольника!";
                    }
                    MessageBox.Show(text, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case MouseButtons.Right:
                    Text = $"Размер области окна - ширина: {ClientSize.Width}px, высота: {ClientSize.Height}px";
                    Thread.Sleep(2500);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}


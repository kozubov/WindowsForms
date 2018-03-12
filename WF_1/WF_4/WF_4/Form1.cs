using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Разработать приложение, созданное на основе форме.
//■■ Пользователь «щелкает» левой кнопкой мыши по форме и, не отпуская кнопку, ведет по ней мышку, а в момент 
//отпускания кнопки по полученным координатам прямоугольника(вам, конечно, известно, что двух точек на плоскости
//достаточно для создания прямоугольника) необходимо создать «статик», который содержит свой порядковый номер
//(имеется в виду порядок появления на форме).
//■■ Минимальный размер «статика» составляет 10х10, при попытке создания элемента меньших размеров пользователь
//должен увидеть соответствующее предупреждение.
//■■ При щелчке правой кнопкой мыши над поверхностью «статика» в заголовке окна должна появиться информация
//о его площади и координатах (относительно формы). В случае, если в точке щелчка находится несколько 
//«статиков», то предпочтение отдается «статику» с наибольшим порядковым номером.
//■■ При двойном щелчке левой кнопки мыши над поверхностью «статика» он должен исчезнуть с формы. В случае,
//если в точке щелчка находится несколько «статиков», то предпочтение отдается «статику» с наименьшим порядковым номером.

namespace WF_4
{
    public partial class Form1 : Form
    {
        int X { get; set; }
        int Y { get; set; }
        int indexStatic { get; set; } = 1;
        public Form1()
        {
            InitializeComponent();
            Text = "ПРИЛОЖЕНИЕ";
            MouseDown += DownMouseForm;
            MouseUp += UpMouseForm;
        }
        private void DownMouseForm(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = e.X;
            Y = e.Y;
        }private void UpMouseForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label staticBox = new Label {BorderStyle = BorderStyle.Fixed3D};
                //определение позиции статика в зависимости с какой стороны его начали рисовать
                if (e.X <= X || e.Y <= Y)
                    if (e.X > X && e.Y < Y)
                    {
                        staticBox.Location = new Point(X, e.Y);
                    }
                    else if (e.X < X && e.Y < Y)
                    {
                        staticBox.Location = new Point(e.X, e.Y);
                    }
                    else
                    {
                        staticBox.Location = new Point(e.X, Y);
                    }
                else
                    staticBox.Location = new Point(X, Y);

                if (Math.Abs(e.X - X) > 10 && Math.Abs(e.Y - Y) > 10)
                {
                    staticBox.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    staticBox.Text = $"{indexStatic}";
                    staticBox.ForeColor = Color.White;
                    staticBox.BackColor = Color.ForestGreen;
                    Controls.Add(staticBox); 
                    Text = $"Статик {staticBox.Text} создан.";
                    staticBox.MouseClick += LabelMouseClick; 
                    staticBox.MouseDoubleClick += LabelMouseDoubleClick;
                    indexStatic++;
                }
                else
                {
                    MessageBox.Show("Нельзя создать «статик» менее 10х10", "Ошибка!", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Для создания «статика» нажмите левую кнопку мышки", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LabelMouseClick(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    foreach (Label item in Controls)
                    {
                        Point position = item.PointToScreen(Point.Empty);
                        if (MousePosition.X > position.X && MousePosition.X < position.X + item.Width && MousePosition.Y > position.Y && MousePosition.Y < position.Y + item.Height)
                        {
                            Text = $"Статик {item.Text}. Площадь: {(item.Width * item.Height):### ###}. Координаты Х: {item.Location.X}, Y: {item.Location.Y}";
                        }
                    }
                    break;
            }
        }
        private void LabelMouseDoubleClick(object sender, MouseEventArgs e)
        {
            int numLabel = indexStatic;
            switch (e.Button)
            {
                case MouseButtons.Left:
                    foreach (Label item in Controls)
                    {
                        Point location = item.PointToScreen(Point.Empty);
                        if (MousePosition.X <= location.X || MousePosition.X >= location.X + item.Width ||
                            MousePosition.Y <= location.Y || MousePosition.Y >= location.Y + item.Height) continue;
                        if (numLabel > Convert.ToInt32(item.Text))
                        {
                            numLabel = Convert.ToInt32(item.Text);
                        }
                    }
                    foreach (Label item in Controls)
                    {
                        if (numLabel != Convert.ToInt32(item.Text)) continue;
                        Text = $@"Статик {item.Text:№ ### ###} удалён";
                        Controls.Remove(item);
                        item.MouseClick -= LabelMouseClick;
                        item.MouseDoubleClick -= LabelMouseDoubleClick;
                    }
                    break;
            }
        }
    }
}

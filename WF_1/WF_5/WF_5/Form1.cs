using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Разработать приложение «убегающий статик»:) Суть приложения: на форме расположен статический элемент 
//управления(«статик»). Пользователь пытается подвести курсор мыши к «статику», и, если курсор находиться 
//близко со статиком, элемент управления «убегает». Предусмотреть перемещение «статика» только в пределах формы.

namespace WF_5
{
    public partial class Form1 : Form
    {
        Label staticBox;
        public Form1()
        {
            InitializeComponent();
            Text = "Убегающий статик";
            staticBox = new Label();
            this.Load += LoadForm;
            this.MouseMove += MouseMoveForm;
        }
        private void LoadForm(object sender, EventArgs e)
        {
            staticBox.BorderStyle = BorderStyle.Fixed3D;
            staticBox.Size = new Size(80, 40);
            staticBox.Text = $"Поймай меня!";
            staticBox.TextAlign = ContentAlignment.MiddleCenter;
            staticBox.AutoSize = false;
            staticBox.ForeColor = Color.White;
            staticBox.BackColor = Color.DarkGreen;
            Controls.Add(staticBox);
            LableCenter(staticBox);
        }
        void LableCenter(Label staticBox) //центрирование
        {
            staticBox.Left = (ClientSize.Width - staticBox.Size.Width) / 2;
            staticBox.Top = (ClientSize.Height - staticBox.Size.Height) / 2;
        }
        private void MouseMoveForm(object sender, MouseEventArgs e)
        {
            if ((e.X <= staticBox.Location.X - 20 || e.X >= staticBox.Location.X + staticBox.Width + 20) ||
                (e.Y <= staticBox.Location.Y - 20 || e.Y >= staticBox.Location.Y + staticBox.Height + 20)) return;
            if (e.X <= staticBox.Location.X - 20 || e.X >= staticBox.Location.X)
            {
                if (e.X < staticBox.Location.X + staticBox.Width + 20 && e.X > staticBox.Location.X + staticBox.Width
                ) //движение курсора справа по оси Х
                {
                    staticBox.Left -= 10;
                }
                else if (e.Y > staticBox.Location.Y - 20 && e.Y < staticBox.Location.Y
                ) //движение курсора сверху по оси У
                {
                    staticBox.Top += 10;
                }
                else if (e.Y < staticBox.Location.Y + staticBox.Height + 20 &&
                         e.Y > staticBox.Location.Y + staticBox.Height) //движение курсора снизу по оси У
                {
                    staticBox.Top -= 10;
                }
            }
            else
            {
                staticBox.Left += 10;
            }
            //Проверка границ окна и возврат «статика» в центр
            if ((staticBox.Location.X >= 0 && staticBox.Location.X <= ClientSize.Width - staticBox.Width) &&
                (staticBox.Location.Y >= 0 && staticBox.Location.Y <= ClientSize.Height - staticBox.Height)) return;
            LableCenter(staticBox);
        }
    }
}

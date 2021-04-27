using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem2
{
    public partial class Form1 : Form
    {
        Color color = Color.Black;
        int x0, y0, x1, y1, r;
        bool isEllips = true;
        Graphics graphic;
        bool isDrawNow = false;
        public Form1()
        {
            InitializeComponent();
            graphic = pictureBox1.CreateGraphics();

        }

        //все что связано с меню сверху экрана
        #region Menu
        private void окружностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isEllips = false;
            label3.Text = "R=";
            label4.Visible = false;
            textBoxY1.Visible = false;
        }

        private void элипсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isEllips = true;
            label3.Text = "A=";
            label4.Visible = true;
            textBoxY1.Visible = true;
        }

        private void очиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void черныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бурашников Р.В\n" +
                "БПИ175\n" +
                "Проект 2. Алгоритм Брезенхема - окружность и эллипс\n" +
                "выполнено в C# VS2019 WinForms\n" +
                "выполенена реализация окружности и элипса через мышку, задание значений и рандома\n" +
                "для сравнения используйте кнопку нарисовать рядом, чтобы увидеть стандартуную реализацию и сравнить с моей\n" +
                "код разбит по регионам и ничего не вынесено в отдельный класс");
        }
        private void какПользоватьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("чтобы нарисовать, выберите фигуры и мышкой или через рандом или черз точное задание занчений нарисуйте");
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            graphic = pictureBox1.CreateGraphics();
        }
        #endregion
        //реализация для рисования мышью, через 3 события
        #region Mouse
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawNow = true;
            x0 = e.X;
            y0 = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDrawNow) return;
            pictureBox1.Refresh();
            x1 = e.X - x0;
            y1 = e.Y-y0;
            if (isEllips)
            {
                graphic.DrawRectangle(new Pen(Color.Red), x0, y0, x1, y1);
                graphic.DrawEllipse(new Pen(Color.Red), x0, y0, x1, y1);
            }
            else 
            {
                r= (int)Math.Sqrt(x1 * x1 + y1 * y1);
                graphic.DrawLine(new Pen(Color.Red),x0, y0, e.X, e.Y);
                graphic.DrawRectangle(new Pen(Color.Red), x0 - r, y0 - r, 2 * r, 2 * r);
                graphic.DrawEllipse(new Pen(Color.Red), x0 - r, y0 - r, 2 * r, 2 * r);
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawNow = false;
            pictureBox1.Refresh();
            if (isEllips)
            {
                DrawEllipse(x0 + x1 / 2, y0 + y1 / 2, x1 / 2, y1 / 2);
            }
            else
                DrawCircle(x0, y0, r);
        }
        #endregion
        //реализация всех кнопок
        #region Button 
        private void Draw_Click(object sender, EventArgs e)
        {
            try
            {
                x0 = int.Parse(textBoxX0.Text);
                y0 = int.Parse(textBoxY0.Text);
                x1 = int.Parse(textBoxX1.Text);
                if (isEllips)
                {
                    y1 = int.Parse(textBoxY1.Text);
                }
                r = x1;
            }
            catch 
            {
                MessageBox.Show("Значения должны быть int");
                return;
            }
            if (isEllips)
                DrawEllipse(x0 + x1 / 2, y0 + y1 / 2, x1 / 2, y1 / 2);
            else
                DrawCircle(x0, y0, r);
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x0 = rnd.Next(pictureBox1.Width);
            y0 = rnd.Next(pictureBox1.Height);
            x1 = rnd.Next(pictureBox1.Width)-x0;
            y1 = rnd.Next(pictureBox1.Height)-y0;
            if (!isEllips) 
            {
                r = Math.Min(pictureBox1.Width- x0,pictureBox1.Height- y0);
            }
            if (isEllips)
            {
                DrawEllipse(x0 + x1 / 2, y0 + y1 / 2, x1 / 2, y1 / 2);
            }
            else
                DrawCircle(x0, y0, r);

        }

        //рисуем рядом с объектом чтобы сравнить качесво через стандартную реализацию
        private void buttonUnder_Click(object sender, EventArgs e)
        {
            if (isEllips)
                graphic.DrawEllipse(new Pen(Color.Red), x0, y0+y1, x1, y1);
            else
                graphic.DrawEllipse(new Pen(Color.Red), x0-r, y0+r, r*2, r*2);
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {

        }
        #endregion
        //реализация построения окружности, эллипса и заливка точки
        #region Bresenham
        private void DrawCircle(int _x, int _y, int radius) 
        {
            int x = 0, y = radius, gap = 0, delta = (2 - 2 * radius);
            while (y >= 0)
            {
                PutPixel(x+_x, _y+y);
                PutPixel(_x+ x, _y- y);
                PutPixel( _x- x,  _y- y);
                PutPixel( _x- x,  _y+ y);
                gap = 2 * (delta + y) - 1;
                if (delta < 0 && gap <= 0)
                {
                    x++;
                    delta += 2 * x + 1;
                    continue;
                }
                else 
                {
                    if (delta > 0 && gap > 0)
                    {
                        y--;
                        delta -= 2 * y + 1;
                        continue;
                    }
                    else 
                    {
                        x++;
                        delta += 2 * (x - y);
                        y--;
                    }
                }
            }
        }
        private void DrawEllipse(int x, int y, int a, int b) 
        {
            if (a <0)
                a = -a;
            if (b < 0)
                b = -b;
            int _x = 0; // Компонента x
            int _y = b; // Компонента y
            int a_sqr = a * a; // a^2, a - большая полуось
            int b_sqr = b * b; // b^2, b - малая полуось
            int delta = 4 * b_sqr * ((_x + 1) * (_x + 1)) + a_sqr * ((2 * _y - 1) * (2 * _y - 1)) - 4 * a_sqr * b_sqr; // Функция координат точки (x+1, y-1/2)
            while (a_sqr * (2 * _y - 1) > 2 * b_sqr * (_x + 1)) // Первая часть дуги
            {
                PutPixel(x + _x, y + _y);
                PutPixel(x + _x, y - _y);
                PutPixel(x - _x, y - _y);
                PutPixel(x - _x, y + _y);
                if (delta < 0) // Переход по горизонтали
                {
                    _x++;
                    delta += 4 * b_sqr * (2 * _x + 3);
                }
                else // Переход по диагонали
                {
                    _x++;
                    delta = delta - 8 * a_sqr * (_y - 1) + 4 * b_sqr * (2 * _x + 3);
                    _y--;
                }
            }
            delta = b_sqr * ((2 * _x + 1) * (2 * _x + 1)) + 4 * a_sqr * ((_y + 1) * (_y + 1)) - 4 * a_sqr * b_sqr; // Функция координат точки (x+1/2, y-1)
            while (_y + 1 != 0) // Вторая часть дуги, если не выполняется условие первого цикла, значит выполняется a^2(2y - 1) <= 2b^2(x + 1)
            {

                PutPixel(x + _x, y + _y);
                PutPixel(x + _x, y - _y);
                PutPixel(x - _x, y - _y);
                PutPixel(x - _x, y + _y);
                if (delta < 0) // Переход по вертикали
                {
                    _y--;
                    delta += 4 * a_sqr * (2 * _y + 3);
                }
                else // Переход по диагонали
                {
                    _y--;
                    delta = delta - 8 * b_sqr * (_x + 1) + 4 * a_sqr * (2 * _y + 3);
                    _x++;
                }
            }
        }
        private void PutPixel(int x, int y)
        {
            graphic.FillRectangle(new SolidBrush(color), x, y, 1, 1);
        }
        #endregion
    }
}

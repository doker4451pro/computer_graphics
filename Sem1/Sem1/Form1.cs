using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sem1
{
    public partial class Form1 : Form
    {
        
        Graphics graphic;
        Color color = Color.Green;
        int x1, y1, x2, y2;
        bool isDrawNow = false;
        public Form1()
        {
            InitializeComponent(); 
            graphic = pictureBox1.CreateGraphics();
        }

        //чистим поле
        private void очиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }


        //нарисовать по заданным координатам
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x1 = int.Parse(textBox1.Text);
                y1 = int.Parse(textBox2.Text);
                x2 = int.Parse(textBox3.Text);
                y2 = int.Parse(textBox4.Text);
            }
            catch 
            {
                MessageBox.Show("Значение должно быть int");
                return;
            }
            DrawLine(x1, y1, x2, y2);
        }

        //евент чтобы нормально рисовать при изменении размера окна
        private void Form1_Resize(object sender, EventArgs e)
        {
            graphic = pictureBox1.CreateGraphics();
        }

        //когда нажали
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            isDrawNow = true;
        }

        //когда отпускаем зажатие мыши
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            isDrawNow = false;
			pictureBox1.Refresh();
            graphic.DrawLine(new Pen(color), x1, y1, x2, y2);
        }
        //пока тянем мыш
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawNow) 
            {
                pictureBox1.Refresh();
                x2 = e.X;
                y2 = e.Y;
                graphic.DrawLine(new Pen(Color.Red),x1,y1,x2,y2);
            }

        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Black;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        //нарисовать через рандом
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            x1 = rnd.Next(pictureBox1.Width);
            y1 = rnd.Next(pictureBox1.Height);
            x2 = rnd.Next(pictureBox1.Width);
            y2 = rnd.Next(pictureBox1.Height);
            DrawLine(x1, y1, x2, y2);
        }

        //нарисовать со смещением
        private void button3_Click(object sender, EventArgs e)
        {
            int delta = 10;
            graphic.DrawLine(new Pen(Color.Black), x1+2*delta, y1+delta, x2+2*delta, y2+delta);
        }

        //о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бурашников Р.В БПИ175\n" +
                "Проект 1. Алгоритм Брезенхема - отрезок\n" +
                "visual studia 2019 winform C# \n" +
                "выполена реализация алгоритма для отрезка и при нажатии на кнопку нарисовать со смещением будет нарисованно рядом чтобы можно было сравнить\n" +
                "реализовано задания прямой через конкртные координаты, рандомом и мышью");
        }
        //рисуем линию по алгоритму
        private void DrawLine(int x0, int y0, int x1, int y1) 
        {
            //Изменения координат
            int dx = (x1 > x0) ? (x1 - x0) : (x0 - x1);
            int dy = (y1 > y0) ? (y1 - y0) : (y0 - y1);
            //Направление приращения
            int sx = (x1 >= x0) ? (1) : (-1);
            int sy = (y1 >= y0) ? (1) : (-1);

            if (dy < dx)
            {
                int d = (dy << 1) - dx;
                int d1 = dy << 1;
                int d2 = (dy - dx) << 1;
                PutPixel(x0, y0);
                int x = x0 + sx;
                int y = y0;
                for (int i = 1; i <= dx; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        y += sy;
                    }
                    else
                        d += d1;
                    PutPixel(x, y);
                    x += sx;
                }
            }
            else
            {
                int d = (dx << 1) - dy;
                int d1 = dx << 1;
                int d2 = (dx - dy) << 1;
                PutPixel(x0, y0);
                int x = x0;
                int y = y0 + sy;
                for (int i = 1; i <= dy; i++)
                {
                    if (d > 0)
                    {
                        d += d2;
                        x += sx;
                    }
                    else
                        d += d1;
                    PutPixel(x, y);
                    y += sy;
                }
            }
        }

        //устанавливае один пиксель
        private void PutPixel(int x, int y)
        {
            graphic.FillRectangle(new SolidBrush(color), x, y, 1, 1);
        }
    }
}

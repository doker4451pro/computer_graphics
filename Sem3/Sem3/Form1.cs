using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Sem3
{
    public partial class Form1 : Form
    {
        #region Fields
        decimal N = 0;
        int maxPoligon, minPologon;
        Pen pen = new Pen(Color.Black);
        Pen redPen = new Pen(Color.Red);
        Color colorFill = Color.Green;
        Color colorback = Color.White;
        Graphics graphics;
        DrawType drawType = DrawType.line;
        Point point;
        bool isDrawNow = false;
        Bitmap bitmap;
        int width, height, r;

        List<Point> points = new List<Point>();

        #endregion

        public Form1()
        {
            InitializeComponent();
            maxPoligon = 0;
            minPologon = pictureBox1.Height;
        }

        #region Button
        private void lineButton_Click(object sender, EventArgs e)
        {
            drawType = DrawType.line;
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            drawType = DrawType.circle;
        }

        private void ellipseButton_Click(object sender, EventArgs e)
        {
            drawType = DrawType.ellipse;
        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            drawType = DrawType.fill;
        }
        private void poligonButton_Click(object sender, EventArgs e)
        {
            drawType = DrawType.poligon;
        }

        //при нажатии должен закрышиваться полигон
        private void xorButton_Click(object sender, EventArgs e)
        {
            if (points.Count == 0)
                return;
            FillClass.PoligonFill(bitmap, points, maxPoligon, minPologon, colorFill);
            points.Clear();
            pictureBox1.Image = bitmap;
        }

        private void colorbutton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                pen = new Pen(dialog.Color);
        }

        private void colorFillButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                colorFill = dialog.Color;
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                colorback = dialog.Color;
                pictureBox1.BackColor = colorback;
            }
        }
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(colorback);
            pictureBox1.Refresh();
        }
        #endregion

        #region Events
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            isDrawNow = true;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawNow) 
            {
                Bitmap temp = new Bitmap(bitmap);
                graphics = Graphics.FromImage(temp);

                width = e.X - point.X;
                height = e.Y - point.Y;
                r = (int)Math.Sqrt(width * width + height * height);
                if (r == 0)
                    return;

                switch (drawType)
                {
                    case DrawType.line:
                        graphics.DrawLine(redPen, point, e.Location);break;
                    case DrawType.circle:
                        {
                            graphics.DrawLine(redPen, point.X, point.Y, e.X, e.Y);
                            graphics.DrawRectangle(redPen, point.X - r, point.Y - r, 2 * r, 2 * r);
                            graphics.DrawEllipse(redPen, point.X - r, point.Y - r, 2 * r, 2 * r);
                            break;
                        }
                    case DrawType.ellipse:
                        {

                            graphics.DrawEllipse(redPen, point.X, point.Y, width, height);
                            graphics.DrawRectangle(redPen, point.X, point.Y, width, height); break;
                        }
                }
                pictureBox1.Image = temp;
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawNow = false;
            if (e.X == point.X)
                return;
            graphics = Graphics.FromImage(bitmap);
            switch (drawType)
            {
                case DrawType.line:
                    graphics.DrawLine(pen, point, e.Location);  break;
                case DrawType.circle:
                    graphics.DrawEllipse(pen, point.X - r, point.Y - r, 2 * r, 2 * r);break;
                case DrawType.ellipse:
                    graphics.DrawEllipse(pen, point.X, point.Y, width, height); break;
            }
            pictureBox1.Image = bitmap;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
        }

        private void poligonButton_Click_1(object sender, EventArgs e)
        {
            drawType = DrawType.poligon;
            N = numericUpDown1.Value;
        }

        private void AboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бурашников Р.В\n" +
                 "БПИ175\n" +
                 "Проект 3. Заливка\n" +
                 "выполнено в C# VS2019 WinForms\n" +
                 "выполена реализация построчная заливка и заливка через полигоны \n" +
                 "управление выполненно через две точки путем перетягивания мыши кроме полигонов там просто клик на поле и когда число будет количеству вершин, оно автоматически замкнеться\n" +
                 "выбор модели для рисования проиходит через кнопки как и выбор цвета\n" +
                 "чтобы закрасить полигон нажмите на кнопку полигонально\n" +
                 "чтобы закрасить по строчно выберите цвет и тыкните на полотно");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            N = numericUpDown1.Value;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            graphics = Graphics.FromImage(bitmap);

            if (drawType == DrawType.fill)
                FillClass.Fill(bitmap, e.Location, colorFill);

            if (drawType == DrawType.poligon)
            {
                if (e.Y > maxPoligon)
                    maxPoligon = e.Y;
                else if (e.Y < minPologon)
                    minPologon = e.Y;

                points.Add(e.Location);
                if (points.Count != 1) 
                {
                    graphics.DrawLine(pen, points[points.Count - 2], e.Location);
                }
                if (points.Count == N)
                {
                    graphics.DrawLine(pen, points[0], e.Location);
                }
            }
            pictureBox1.Image = bitmap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
        }
        #endregion

        #region Metods
        #endregion
    }
}

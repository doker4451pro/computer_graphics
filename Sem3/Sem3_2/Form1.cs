using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem3_2
{
    public partial class Form1 : Form
    {
        #region Fields
        DrawType draw = DrawType.line;
        ClipType clip = ClipType.standart;
        Point point;
        List<Line> lines;
        Rectangle rectangle;
        bool isDrawNow = false;
        Bitmap bitmap;
        Graphics graphics;
        Pen redPen = new Pen(Color.Red);

        #endregion
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitmap;
            lines = new List<Line>();
            graphics = Graphics.FromImage(bitmap);
        }

        #region Buttons
        private void cleatButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pictureBox1.Image = bitmap;
            lines.Clear();
            rectangle = null;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бурашников Р.В\n" +
                "БПИ175\n" +
                "Проект 3. Отсечения Сазерленда-Коэна\n" +
                "выполнено в C# VS2019 WinForms\n" +
                "выполена реализация отсечения \n" +
                "управление выполненно через две точки путем перетягивания мыши \n" +
                "выбора цвета нет, так как умение пользоваться этим инструментом было продемонстрировано в предыдущей домашке\n" +
                "чтобы показать как есть нажмите стандарт\n" +
                "чтобы показать 3 цветами какая видимость у линий нажмите частично\n" +
                "чтобы произвести отсечение нажмите обрезать" +
                "чтобы закрасить по строчно выберите цвет и тыкните на полотно\n" +
                "Черный цвет- видно полностью\n" +
                "Зеленый цвет-видно частично\n" +
                "Красный цвет-не видно");
        }

        private void linebutton_Click(object sender, EventArgs e)
        {
            draw = DrawType.line;
            clip = ClipType.standart;
        }

        private void rectanglebutton_Click(object sender, EventArgs e)
        {
            draw = DrawType.rectangle;
            clip = ClipType.standart;
        }

        private void standartButton_Click(object sender, EventArgs e)
        {
            clip = ClipType.standart;
            ClipClass.DrawAllVisible(graphics, lines, rectangle);
            pictureBox1.Image = bitmap;
        }

        private void partialButton_Click(object sender, EventArgs e)
        {
            clip = ClipType.partial;
            ClipClass.DrawParsial(graphics, lines, rectangle);
            pictureBox1.Image = bitmap;
        }

        private void Clipbutton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            clip = ClipType.cliping;
            ClipClass.DrawAllNotVisible(graphics, lines,rectangle);
            pictureBox1.Image = bitmap;
        }

        private void randombutton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            lines.Add(new Line(new Point(rnd.Next(pictureBox1.Width),rnd.Next(pictureBox1.Height)), new Point(rnd.Next(pictureBox1.Width), rnd.Next(pictureBox1.Height))));
            //проверяем видимость новой линии
            ClipClass.SetLineType(lines[lines.Count - 1], rectangle);
            ClipClass.DrawAllVisible(graphics, lines, rectangle);
            pictureBox1.Image = bitmap;
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
            if (!isDrawNow) return;
            Bitmap temp = new Bitmap(bitmap);

            Graphics graphics = Graphics.FromImage(temp);
            if (draw == DrawType.line)
            {
                graphics.DrawLine(redPen, point, e.Location);
            }
            else 
            {
                graphics.DrawRectangle(redPen, point.X, point.Y, e.X - point.X, e.Y - point.Y);
                rectangle = new Rectangle(point, e.Location);

            }
            pictureBox1.Image = temp;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (draw == DrawType.line)
            {
                lines.Add(new Line(point, e.Location));
                //проверяем видимость новой линии
                ClipClass.SetLineType(lines[lines.Count-1], rectangle);
                ClipClass.DrawAllVisible(graphics, lines, rectangle);
            }
            else 
            {
                //проверяем видимость всех линий относительно нового прямоугольника
                ClipClass.SetLinesType(lines, rectangle);
                ClipClass.DrawAllVisible(graphics, lines, rectangle);
            }
            isDrawNow = false;
            pictureBox1.Image = bitmap;
        }
        #endregion

    }
}

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
using ClassLibraryFor3D;

namespace Sem5
{
    public partial class Form1 : Form
    {
        const double Scale = 1.25;
        const double Shift = 10;
        const double Rotation = 0.2;
        const int dz = 200;

        Graphics graphic;
        bool isPerspective = true;
        Body curFigura = new Pyramid();
        //начало координат
        int dx, dy;
        public Form1()
        {
            InitializeComponent();
            dx = pictureBox1.Width / 2;
            dy = pictureBox1.Height / 2;
            graphic = pictureBox1.CreateGraphics();
        }

        #region Button
        private void button1_Click(object sender, EventArgs e)
        {
            curFigura.ScaleX(Scale);
            DrawAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            curFigura.ScaleY(Scale);
            DrawAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            curFigura.ScaleZ(Scale);
            DrawAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            curFigura.ScaleAll(Scale);
            DrawAll();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            curFigura.ScaleX(1 / Scale);
            DrawAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            curFigura.ScaleY(1 / Scale);
            DrawAll();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            curFigura.ScaleZ(1 / Scale);
            DrawAll();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            curFigura.ScaleAll(1 / Scale);
            DrawAll();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            curFigura.MovingX(Shift);
            DrawAll();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            curFigura.MovingX(-Shift);
            DrawAll();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            curFigura.MovingY(Shift);
            DrawAll();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            curFigura.MovingY(-Shift);
            DrawAll();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            curFigura.MovingZ(Shift);
            DrawAll();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            curFigura.MovingZ(-Shift);
            DrawAll();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            curFigura.RotationX(Rotation);
            DrawAll();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            curFigura.RotationX(-Rotation);
            DrawAll();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            curFigura.RotationY(Rotation);
            DrawAll();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            curFigura.RotationY(-Rotation);
            DrawAll();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            curFigura.RotationZ(Rotation);
            DrawAll();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            curFigura.RotationZ(-Rotation);
            DrawAll();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            isPerspective = true;
            DrawAll();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            isPerspective = false;
            DrawAll();
        }
        #endregion

        #region Metods
        private void DrawGrid()
        {
            graphic.DrawLine(new Pen(Color.Black), dx, 0, dx, 2 * dy);
            graphic.DrawLine(new Pen(Color.Black), 0, dy, 2 * dx, dy);
        }
        private void DrawFigure() 
        {
            var points = curFigura.GetFinalPoint();
            var edges = curFigura.GetFinalEdge();

            if (isPerspective)
                points = curFigura.PerspectiveProjection(dz);

            Pen pen = new Pen(Color.Red);

            for (int i = 0; i < edges.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    graphic.DrawLine(pen,
                        (float)points[edges[i, j] - 1, 0] + dx,
                        (float)points[edges[i, j] - 1, 1] + dy,
                        (float)points[edges[i, j + 1] - 1, 0] + dx,
                        (float)points[edges[i, j + 1] - 1, 1] + dy);
                }
                graphic.DrawLine(pen,
                        (float)points[edges[i, 2] - 1, 0] + dx,
                        (float)points[edges[i, 2] - 1, 1] + dy,
                        (float)points[edges[i, 0] - 1, 0] + dx,
                        (float)points[edges[i, 0] - 1, 1] + dy);
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            curFigura = new Cube();
            DrawAll();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            curFigura = new Pyramid();
            DrawAll();
        }
        //волчек
        private void button26_Click(object sender, EventArgs e)
        {
            int n = 100;
            curFigura = new Pyramid();

            DrawAll();
            Thread.Sleep(100);

            for (int i = 0; i < n; i++)
            {
                curFigura.RotationY(Rotation);
                DrawAll();
                Thread.Sleep(100);
            }
            for (int i = 0; i < n / 10; i++)
            {
                curFigura.MovingX(Shift);
                DrawAll();
                Thread.Sleep(100);
            }
        }
        //карусель
        private void button27_Click(object sender, EventArgs e)
        {
            int n = 100;
            curFigura = new Pyramid();

            DrawAll();
            Thread.Sleep(100);

            for (int i = 0; i < n/10; i++)
            {
                curFigura.MovingX(Shift);
                DrawAll();
                Thread.Sleep(100);
            }
            for (int i = 0; i < n; i++)
            {
                curFigura.RotationY(Rotation);
                DrawAll();
                Thread.Sleep(100);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Бурашников Р.В\n" +
                "БПИ175\n" +
                "Проект 5. Базовые преобразования и проекции\n" +
                "выполнено в C# VS2019 WinForms\n" +
                "выполена реализация через аффинные преобразования \n" +
                "управление выполненно через клавиши\n" +
                "для лучшей визуализации показывается только один объект\n" +
                "Для рисования все находится в Form1.cs\n" +
                "для удобства разработки и дальнейшего поддержания было прянято решение вынести реализацию в отдельную библиотеку классов ClassLibraryFor3D\n" +
                "В этой библиотке реализованы афииные преобразования и данные для фигур для удосьва вынесеные в отдельный абстрактный класс Body.cs\n" +
                "класс Transformation содержит все аффинные преобразования\n" +
                "реализованно две кнопки для показа результатов: волчек и карусель\n" +
                "волчек- вращение и потом перемещение\n" +
                "карусель- перемещение потом вращение");
        }

        private void DrawAll()
        {
            graphic.Clear(Color.White);
            DrawFigure();
            DrawGrid();
        }
        #endregion

    }
}

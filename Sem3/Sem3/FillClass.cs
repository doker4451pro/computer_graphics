using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3
{
    enum DrawType 
    {
        line,
        circle,
        ellipse,
        fill,
        poligon

    }

    public static class FillClass 
    {
        public static void Fill(Bitmap bitmap, Point point, Color color) 
        {
            Stack<Point> stack=new Stack<Point>();
            stack.Push(point);


            Color backColor =bitmap.GetPixel(point.X,point.Y);

            if (backColor == color)
                return;
            while (stack.Count != 0) 
            {
                Point temp = stack.Pop();

                int rigthX = temp.X + 1;
                int leftX = temp.X;

                while (rigthX < bitmap.Width && bitmap.GetPixel(rigthX, temp.Y) == backColor) 
                {
                    bitmap.SetPixel(rigthX, temp.Y, color);
                    rigthX++;
                }
                rigthX--;

                while (leftX >= 0 && bitmap.GetPixel(leftX, temp.Y) == backColor)
                {
                    bitmap.SetPixel(leftX, temp.Y, color);
                    leftX--;
                }
                leftX++;


                if (temp.Y - 1 >= 0)
                {
                    ScanLine(temp.Y - 1, leftX, rigthX, stack, bitmap, backColor);
                }

                if (temp.Y + 1 < bitmap.Height)
                {
                    ScanLine(temp.Y + 1, leftX, rigthX, stack, bitmap, backColor);
                }
            }
        }

        private static void ScanLine(int y, int leftX, int rightX, Stack<Point> points, Bitmap bitmap, Color backColor)  
        {
            for (int i = leftX; i <= rightX; i++)
            {
                if(bitmap.GetPixel(i, y) == backColor)
                    points.Push(new Point(i - 1, y));
            }
        }

        public static void PoligonFill(Bitmap bitmap, List<Point> points,int maxPol, int minPol, Color fillColor) 
        {
            points.Add(points[0]);
            points.Add(points[1]);

            for (int y = minPol; y <=maxPol ; y++)
            {
                List<int> xcoords = new List<int>();
                for (int i = 0; i < points.Count-2; i++)
                {
                    if (points[i + 1].Y != points[i].Y) 
                    {
                        Point first = points[i];
                        Point second = points[i + 1];
                        double x=(double)(((second.X - first.X) * y + (first.X * second.Y - second.X * first.Y))) / (double)((second.Y - first.Y));

                        if ((x < second.X && x > first.X) || (x < first.X && x > second.X))
                        {
                            xcoords.Add((int)x);
                        }
                        else if (x == second.X) 
                        {
                            if ((y < first.Y && y > (points[i + 2].Y) || (y > first.Y && y < (points)[i + 2].Y)))
                            {
                                xcoords.Add((int)x);
                            }
                            i++;
                        }
                    }
                }
                if (xcoords.Count > 0) 
                {
                    xcoords.Sort();
                    for (int i = 0; i < xcoords.Count-1; i+=2)
                    {
                        for (int j = xcoords[i]; j <= xcoords[i+1]; j++)
                        {
                            bitmap.SetPixel(j, y, fillColor);
                        }
                    }
                }
            }
        }

    }
}

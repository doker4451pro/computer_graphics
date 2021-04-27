using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3_2
{
    enum DrawType
    {
        line,
        rectangle
    }
    enum ClipType 
    {
        standart=0,
        partial,
        cliping
    }

    enum LineType 
    {
        visible,
        partial,
        notvisible
    }
    static class  ClipClass
    {


        //просто рисуем линии одного цвета
        public static void DrawAllVisible(Graphics graphics, List<Line> lines, Rectangle rectangle) 
        {
            graphics.Clear(Color.White);
            foreach (var item in lines)
            {
                graphics.DrawLine(Line.penVisible, item.First, item.Last);
            }
            if(rectangle!=null)
                graphics.DrawRectangle(Rectangle.Pen, rectangle.x0, rectangle.y0, Math.Abs(rectangle.x1 - rectangle.x0), Math.Abs(rectangle.y1 - rectangle.y0));
        }



        //рисуем линии и красим их в зависимости от расположения
        public static void DrawParsial(Graphics graphics, List<Line> lines, Rectangle rectangle) 
        {
            if (rectangle != null)
                graphics.DrawRectangle(Rectangle.Pen, rectangle.x0, rectangle.y0, Math.Abs(rectangle.x1-rectangle.x0), Math.Abs(rectangle.y1 - rectangle.y0));
            foreach (var item in lines)
            {
                if(item.type==LineType.visible)
                    graphics.DrawLine(Line.penVisible, item.First, item.Last);
                if(item.type == LineType.partial)
                    graphics.DrawLine(Line.penParsial, item.First, item.Last);
                if(item.type == LineType.notvisible)
                    graphics.DrawLine(Line.penNotVisible, item.First, item.Last);
            }
        }

        //образаем линии и рисуем и как видимые
        public static void DrawAllNotVisible(Graphics graphics, List<Line> lines,Rectangle rectangle) 
        {
            if (rectangle != null)
                graphics.DrawRectangle(Rectangle.Pen, rectangle.x0, rectangle.y0, Math.Abs(rectangle.x1 - rectangle.x0), Math.Abs(rectangle.y1 - rectangle.y0));

            foreach (var item in lines)
            {
                DrawNotVisible(graphics, item);
            }
        }

        private static void DrawNotVisible(Graphics graphics, Line line) 
        {
            int x1 = line.First.X;
            int y1 = line.First.Y;
            int x2 = line.Last.X;
            int y2 = line.Last.Y;

            if (line.type == LineType.partial)
            {
                if (!line.intersection1.IsEmpty)
                {
                    x1 = line.intersection1.X;
                    y1 = line.intersection1.Y;
                }
                if (!line.intersection2.IsEmpty)
                {
                    x2 = line.intersection2.X;
                    y2 = line.intersection2.Y;
                }
            }

            if (line.type!= LineType.notvisible)
                graphics.DrawLine(Line.penVisible, x1, y1, x2, y2);
        }

        public static void SetLineType(Line line, Rectangle rectangle) 
        {
            //если нет прямоугольника то все они видимые и ничего делать не надо
            if (rectangle == null)
                return;

            line.Clear();

            int x1 = line.First.X;
            int y1 = line.First.Y;
            int x2 = line.Last.X;
            int y2 = line.Last.Y;

            int point1_outcode = outCode(rectangle, x1, y1);
            int point2_outcode = outCode(rectangle, x2, y2);

            while (true) 
            {
                if ((point1_outcode | point2_outcode) == 0)
                {
                    break;
                }
                else if ((point1_outcode & point2_outcode) != 0)
                {
                    line.type = LineType.notvisible;
                    break;
                }
                else 
                {
                    line.type = LineType.partial;

                    int outcode;
                    int x0, y0;

                    if (point1_outcode > point2_outcode)
                    {
                        outcode = point1_outcode;
                        x0 = x1;
                        y0 = y1;
                    }
                    else
                    {
                        outcode = point2_outcode;
                        x0 = x2;
                        y0 = y2;
                    }

                    double x=0, y=0;
                    double m;

                    if (y2 - y1 == 0)
                        m = 0;
                    else if (x2 - x1 == 0)
                        m = Double.MaxValue;
                    else
                        m = (double)(y2 - y1) / (x2 - x1);



                    if ((outcode & TOP) != 0 && m != 0)
                    {
                        y = rectangle.y1;
                        x = x0 + (1 / m) * (y - y0);
                    }
                    else if ((outcode & BOTTOM) != 0 && m != 0)
                    {
                        y = rectangle.y0;
                        x = x0 + (1 / m) * (y - y0);
                    }
                    else if ((outcode & RIGHT) != 0 && m != Double.MaxValue)
                    {
                        x = rectangle.x1;
                        y = y0 + m * (x - x0);
                    }
                    else if ((outcode & LEFT) != 0 && m != Double.MaxValue)
                    {
                        x = rectangle.x0;
                        y = y0 + m * (x - x0);
                    }

                    if (outcode == point1_outcode)
                    {
                        line.intersection1.X = (int)x;
                        line.intersection1.Y = (int)y;
                        point1_outcode = outCode(rectangle, (int)x, (int)y);
                    }
                    else
                    {
                        line.intersection2.X = (int)x;
                        line.intersection2.Y = (int)y;
                        point2_outcode = outCode(rectangle, (int)x, (int)y);
                    }
                }
            }
        }
        public static void SetLinesType(List<Line> lines, Rectangle rectangle) 
        {
            //если нет линий
            if (lines.Count == 0)
                return;
            foreach (var item in lines)
            {
                SetLineType(item, rectangle);
            }
        }



        const int INSIDE = 0; // 0000
        const int LEFT = 1;   // 0001
        const int RIGHT = 2;  // 0010
        const int BOTTOM = 4; // 0100
        const int TOP = 8;    // 1000

        private static int outCode(Rectangle rectangle, int x, int y)
        {
            int code = INSIDE;

            if (x < rectangle.x0)
                code |= LEFT;
            else if (x > rectangle.x1)
                code |= RIGHT;
            if (y < rectangle.y0)
                code |= BOTTOM;
            else if (y > rectangle.y1)
                code |= TOP;

            return code;
        }
    }

    class Line 
    {
        public Point First;
        public Point Last;
        public static Pen penVisible = new Pen(Color.Black);
        public static Pen penParsial = new Pen(Color.Green);
        public static Pen penNotVisible = new Pen(Color.Red);

        public LineType type = LineType.visible;

        public Point intersection1;
        public Point intersection2;

        public Line(Point first, Point last) 
        {
            First = first;
            Last = last;
        }
        public void Clear() 
        {
            type = LineType.visible;
            intersection1 = Point.Empty;
            intersection2 = Point.Empty;
        }
    }

    class Rectangle 
    {
        public int x0, y0, x1, y1;
        public static Pen Pen= new Pen(Color.DarkBlue);
        public Rectangle(Point first, Point last) 
        {
            x0 = first.X;
            y0 = first.Y;
            x1 = last.X;
            y1 = last.Y;
        }
    }
}

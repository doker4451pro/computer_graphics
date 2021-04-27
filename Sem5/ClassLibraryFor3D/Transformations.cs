using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFor3D
{
    static class Transformations
    {
        public static double[,] RotationX(double angle) 
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, Math.Cos(angle), Math.Sin(angle), 0 }, { 0, -Math.Sin(angle), Math.Cos(angle), 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] RotationY(double angle)
        {
            return new double[4, 4] { { Math.Cos(angle), 0, -Math.Sin(angle), 0 }, { 0, 1, 0, 0 }, { Math.Sin(angle), 0, Math.Cos(angle), 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] RotationZ(double angle)
        {
            return new double[4, 4] { { Math.Cos(angle), Math.Sin(angle), 0, 0 }, { -Math.Sin(angle), Math.Cos(angle), 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] ScaleX(double Coef)
        {
            return new double[4, 4] { { Coef, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] ScaleY(double Coef)
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, Coef, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] ScaleZ(double Coef)
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, Coef, 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] ScaleAll(double Coef)
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, Coef } };
        }
        public static double[,] MovingX(double delta)
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { delta, 0, 0, 1 } };
        }
        public static double[,] MovingY(double delta)
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, delta, 0, 1 } };
        }
        public static double[,] MovingZ(double delta)
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, delta, 1 } };
        }
        public static double[,] ParallelProjection()
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 1 } };
        }
        public static double[,] PerspectiveProjection(double r)
        {
            return new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, -1/r }, { 0, 0, 0, 1 } };
        }

    }
}

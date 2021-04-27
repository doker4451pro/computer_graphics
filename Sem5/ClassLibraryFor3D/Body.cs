using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFor3D
{
    public abstract class Body
    {
        protected abstract  uint N { get; }
        protected uint M { get { return 2 * N - 4; } }
        //матрица граней B
        protected int[,] MatrixB;
        //матрица вершин A(координаты)
        protected double[,] MatrixA;
        //матрица преобразований P
        protected double[,] MatrixP = new double[4, 4] { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 1 } };

        public void RotationX(double angle) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.RotationX(angle));
        public void RotationY(double angle) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.RotationY(angle));
        public void RotationZ(double angle) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.RotationZ(angle));
        public void MovingX(double delta) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.MovingX(delta));
        public void MovingY(double delta) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.MovingY(delta));
        public void MovingZ(double delta) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.MovingZ(delta));
        public void ScaleX(double coef) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.ScaleX(coef));
        public void ScaleY(double coef) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.ScaleY(coef));
        public void ScaleZ(double coef) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.ScaleZ(coef));
        public void ScaleAll(double coef) =>
            MatrixA = MultiplicationMatrix(MatrixA, Transformations.ScaleAll(coef));
        public double[,] ParallelProjection()=>
            MultiplicationMatrix(MatrixA, Transformations.ParallelProjection());
        public double[,] PerspectiveProjection(double r) =>
             MultiplicationMatrix(MatrixA, Transformations.PerspectiveProjection(r));
        public double[,] GetFinalPoint() 
        {
            double[,] matrix = new double[MatrixA.GetUpperBound(0)+1,2];
            for (int i = 0; i < MatrixA.GetUpperBound(0)+1; i++)
            {
                matrix[i, 0] = MatrixA[i, 0];
                matrix[i, 1] = MatrixA[i, 1];
            }
            return matrix;
        }
        public int[,] GetFinalEdge() 
        {
            return MatrixB;
        }
        //умножение матриц
        private double[,] MultiplicationMatrix(double[,] matrixA, double[,] matrixB) 
        {
            double[,] C = new double[matrixA.GetUpperBound(0)+1,matrixB.GetUpperBound(1)+1]; //Столько же строк, сколько в А; столько столбцов, сколько в B 
            for (int i = 0; i < matrixA.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < matrixB.GetUpperBound(1) + 1; ++j)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < matrixA.GetUpperBound(1) + 1; ++k)
                    { //ТРЕТИЙ цикл, до A.m=B.n
                        C[i, j] += matrixA[i, k] * matrixB[k, j]; //Собираем сумму произведений
                    }
                }
            }
            ////нормаровка
            for (int i = 0; i < C.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < C.GetUpperBound(1)+1; j++)
                {
                    C[i, j] = C[i, j] / C[i, 3];
                }
            }
            return C;
        }
    }
}

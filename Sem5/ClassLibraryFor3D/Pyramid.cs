using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFor3D
{
    public class Pyramid : Body
    {
        protected override uint N { get { return 4; } }
        public Pyramid() 
        {
            MatrixA = new double[,] { { 0, 0, 0, 1 }, {100,0,0,1 }, {50,Math.Sqrt(3)/2*100,0,1 }, {50,Math.Sqrt(3)/6*100,Math.Sqrt(2)/Math.Sqrt(3)*100,1 } };
            MatrixB = new int[,] { {1,2,3 }, {1,2,4 }, {1,3,4 }, {2,3,4 }};
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFor3D
{
    public class Cube : Body
    {
        protected override uint N { get { return 8; } }
        public Cube() 
        {
            MatrixA = new double[8, 4] { {50,50,50,1 }, {-50,50,50,1 }, {-50,-50,50,1 }, { 50,-50,50,1}, {50,50,-50,1 }, {-50,50,-50,1 }, {-50,-50,-50,1 }, {50,-50,-50,1 } };
            MatrixB = new int[12, 3] { {1,2,3 }, {1,3,4 }, {5,1,4 }, {5,4,8 }, {6,5,8 }, {6,8,7 }, {2,6,7 }, {2,7,3 }, {5,6,2 }, {5,2,1 }, {3,7,8 }, {3,8,4 } };
        }
    }
}

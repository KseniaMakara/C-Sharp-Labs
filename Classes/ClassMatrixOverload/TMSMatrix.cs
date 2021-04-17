using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMatrixOverload
{
    class TMSMatrix:Mat
    {
        public TMSMatrix(int n, int[,] matrix) : base(n, matrix)
        {
        }
       public TMSMatrix():base()
        {

        }
        public void Transpon()
        {
            int[,] trans = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    trans[i, j] = matrix[j, i];
                }
            }
            matrix = trans;
            PrintMat();  
        }
        public void Determinant()
        {
            int determin;
            if (n == 2)
                determin = matrix[0, 0]*matrix[1,1] - matrix[0, 1]* matrix[1, 0];
            else if(n==3)
                determin = matrix[0, 0] * matrix[1, 1]* matrix[2, 3] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] + matrix[0, 1] * matrix[1, 3] * matrix[2, 0] - (matrix[0, 2] * matrix[1, 1]* matrix[2, 0] + matrix[0, 0] * matrix[2, 1] * matrix[1, 3] + matrix[1, 0] * matrix[0, 1] * matrix[2, 3]);
        }
    }
}

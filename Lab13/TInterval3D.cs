using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_18_
{
    class TInterval3D : TInterval2D
    {
        public int Z1, Z2;
        public TInterval3D(int x1, int x2, int y1, int y2, int z1, int z2) : base(x1, x2, y1, y2) //констрктор з параметрами
        {
            Z1 = z1;
            Z2 = z2;
        }
        public TInterval3D(TInterval2D o) //констрктор з параметрами
        {
            Z1 = 6;
            Z2 = 2;
            this.X1 = o.X1;
            this.X2 = o.X2;
            this.Y1 = o.Y1;
            this.Y2 = o.Y2;


        }
        public new void EnterPrint()
        {
            int Z1 = Convert.ToInt32(Console.ReadLine());
            int Z2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{Z1}, {Z2}, {base.X1}, {base.X1}, {base.Y1}, {base.Y1}"); 
        }
        public new void Middle()
        { 
            int c_z = (Z1 - Z2) / 2;
            Console.WriteLine( $"{c_z}, {base.Middle(x2, X2, Y1, Y2)}");
        }
    }
}

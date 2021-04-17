using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_17_
{
    abstract class TLine
    {
       public int x, y;
        public TLine(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public TLine()
        {
            x = 5;
            y = 4;
        }
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public abstract bool Parallel(TLine otherObj, int a, int b, int p);

        public abstract bool Perpendicular(TLine other, int a, int b, int p);

        public abstract bool Belonging(TLine point, int koef, int a, int b, int p); 
    }
}

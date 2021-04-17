using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_17_
{
    class LinePlane: TLine
    {
        public LinePlane(int x, int y) : base(x, y)
        {
        }
        public override bool Parallel(TLine otherObj, int a, int b, int p = 0)
        {
            if (x / a == y / b)
                return true;
            return false;
        }
        public override bool Perpendicular(TLine other, int a, int b, int p)
        {
            if (!(other is LineSpace))
                throw new Exception("The object is not LineSpace");
            LineSpace line = other as LineSpace;
            if (x * a + y * b == 0)
                return true;
            return false;
        }
        public override bool Belonging(TLine point, int koef, int a, int b, int p)
        {
            if (x * a + y * b + koef == 0)
                return true;
            return false;
        }
    }
}

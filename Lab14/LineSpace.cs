using System;
using System.Collections.Generic;
using System.Text;

namespace Lab14_17_
{
    class LineSpace: TLine
    {
        int z;
        public LineSpace(int x, int y, int z) :base(x,y)
        {
            this.z = z;
        }
        public override bool Parallel(TLine otherObj, int a, int b, int p)
        {
            if (!(otherObj is LineSpace))
                throw new Exception("The object is not LineSpace");
            LineSpace line = otherObj as LineSpace;
            if (line.x / a == line.y / b && line.x / a == line.z / p && line.y / b == line.z / p)
                return true;
            return false;

        }
        public override bool Perpendicular(TLine other, int a, int b, int p)
        {
            if (!(other is LineSpace))
                throw new Exception("The object is not LineSpace");
            LineSpace line = other as LineSpace;
            if (line.x * a + line.y * b + z * p == 0)
                return true;
            return false;
        }
        public override bool Belonging(TLine point, int koef, int a, int b, int p)
        {
            if (point.x * a + point.y * b + z*p + koef == 0)
                return true;
            return false;
        }
}
}



using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_5_
{
    class Solution: IEquationing
    {
        double a { get; set;  }
        double b { get; set; }
        double c { get; set; }

        public Solution()
        {
            a = 1;
            b = 3;
            c = -5;
        }
        public Solution(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        double IEquationing.Discriminant()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
        (double, double) IEquationing.Root2()
        {
            double x1 = -b + Math.Sqrt(((IEquationing)this).Discriminant())/2 * a;
            double x2 = -b - Math.Sqrt(((IEquationing)this).Discriminant())/ 2 * a;

            return (x1, x2);
        }
        void IEquationing.Root()
        {
            if (((IEquationing)this).Discriminant() < 0)
            {
                Console.WriteLine("No roots");
            }
            else if (((IEquationing)this).Discriminant() == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Root is {x}");
            }
            else
            {
                Console.WriteLine(((IEquationing)this).Root2());
            }
        }
    }
}

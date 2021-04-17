using System;

namespace Класи11_13_
{
    class Program
    {
        static void Main(string[] args)
        {
            Line l = new Line();
            Line o = new Line(2,7);
            Console.WriteLine(l.Enter(1,4));
            l.Crossing(1, 5, 8, 3);
            Line p = l + o;
            Console.WriteLine(p);
        }
    }
}

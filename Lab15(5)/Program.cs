using System;

namespace Lab15_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution s1 = new Solution(3,-18,27);
            IEquationing i1 = s1;
            i1.Root();
        }
    }
}

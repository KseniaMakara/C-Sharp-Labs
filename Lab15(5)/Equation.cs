using System;
using System.Collections.Generic;
using System.Text;

namespace Lab15_5_
{
    public interface IEquationing
    {
     
        (double, double ) Root2();
        void Root();
        double Discriminant();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Math.Library
{
    interface IMath
    {
        double Add(double n1, double n2);

        double Sub(double n1, double n2);

        double Mul(double n1, double n2);

        double Div(double n1, double n2);

        double Abs(double n1);

        long Fact(int n);

        double Sqrt(double n1, double n2);

        double Pow(double n1, double n2);
    }
}

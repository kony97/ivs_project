using System;

namespace Math.Library
{
    public class Math
    {
        public static double Abs(double n1)
        {
            if (n1 < 0) return -n1;
            return n1; 
        }

        public static double Add(double n1, double n2) //sčítání
        {
            return n1 + n2;
        }

        public static double Div(double n1, double n2) //dělení
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Nulou nelze dělit");
            }
            return n1 / n2;
        }

        public static long Fact(int n) //faktoriál
        {
            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public static double Mul(double n1, double n2) //násobení
        {
            return n1 * n2;
        }


        public static double Pow(double n1, double n2) //N1 umocněno na N2
        {
            return System.Math.Pow(n1, n2);
        }

        public static double Sqrt(double n1, double n2) //odmocnina
        {
            if (n1 <= 0) return -1;
            else
            {
                double n3 = Div(1.0, n2);
                double root = Pow(n1, n3);
                return root;
            }
        }

        public static double Sub(double n1, double n2)//odčítá N2 od N1 a vrací N1
        {
            return n1 - n2;
        }
    }
}

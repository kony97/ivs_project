using System;

namespace Math.Library
{
    public class Math : IMath
    {
        public double Abs(double n1)
        {
            if (n1 < 0) return -n1;
            return n1; 
        }

        public double Add(double n1, double n2) //sčítání
        {
            return n1 + n2;
        }

        public double Div(double n1, double n2) //dělení
        {
            return n1 / n2;
        }

        public long Fact(int n) //faktoriál
        {
            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        public double Mul(double n1, double n2) //násobení
        {
            return n1 * n2;
        }

        
        public double Pow(double n1, double n2) //N1 umocněno na N2
        {
            if (n2 == 0) return 1;
            else
            {
                double mocnina = 1;
                for(int i = 0; i < n2; i++)
                {
                    mocnina *= n1;
                }
                return mocnina;
            }
            
        }

        public double Sqrt(double n1, double n2) //odmocnina
        {
            //TODO
            return n1;
        }

        public double Sub(double n1, double n2)//odčítá N2 od N1 a vrací N1
        {
            return n1 - n2;
        }
    }
}

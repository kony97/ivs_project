using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;

namespace Profiling
{
    class Program
    {
        
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Us");
            string s;
            List<double> numbers = new List<double>();
            double x1 = 0, sum=0,sum2=0;
            Math.Library.Math math = new Math.Library.Math();

            while ((s = Console.ReadLine()) != null)
            {
                s = Regex.Replace(s, @"\s+", " ");

                string[] numbersString = s.Split(" ");

                foreach (var number in numbersString)
                {
                    double n;
                    bool success = Double.TryParse(number, out n);

                    if (success)
                    {
                        numbers.Add(n);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not valid number", number);
                        return;
                    }
                }
            }

            foreach (var n in numbers)
            {
                sum = math.Add(sum, n);
            }

            x1 = math.Add(math.Div(1,numbers.Count), sum);

            foreach (var n in numbers)
            {
                double n1 = 0, n2 = 0;

                n1 = math.Pow(n, 2);
                n2 = math.Mul(numbers.Count, math.Pow(x1, 2));

                sum2 = math.Add(sum2,math.Sub(n1,n2));
            }

            double res = math.Sqrt(math.Mul(math.Div(1,math.Sub(numbers.Count,1)),x1), 2);

            Console.WriteLine(res);
        }
    }
}

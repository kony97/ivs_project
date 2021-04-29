/****************************************************
 * Název projektu: Kalkulačka
 * Soubor: Program.cs
 * Datum: 20.4.2021
 * Poslední změna: 28.4.2021
 * Autor: ASSC tým
 * 
 * Popis: Profiling
 * 
 ****************************************************
 /**
 * @file Program.cs
 * 
 * @autor ASSC tým
 */

using System;
using System.Collections.Generic;
using System.Globalization;
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
            
            //Načitá hodnoty z konzole
            while ((s = Console.ReadLine()) != null)
            {
                s = Regex.Replace(s, @"\s+", " ");

                string[] numbersString = s.Split(" ");
                
                //Přidává validní čísla do Listu
                foreach (var number in numbersString)
                {
                    double n;
                    bool success = Double.TryParse(number, out n);
                    
                    //Pokud je číslo validní - přidá číslo do listu
                    if (success)
                    {
                        numbers.Add(n);
                    }
                    //Pokud není validní - ukončí se a napíše, které číslo není validné
                    else
                    {
                        Console.WriteLine("{0} is not valid number", number);
                        return;
                    }
                }
            }
            
            //Výpočet vzorce ze zadání
            foreach (var n in numbers)
            {
                sum = Math.Library.Math.Add(sum, n);
            }

            x1 = Math.Library.Math.Add(Math.Library.Math.Div(1,numbers.Count), sum);

            foreach (var n in numbers)
            {
                double n1 = 0, n2 = 0;

                n1 = Math.Library.Math.Pow(n, 2);
                n2 = Math.Library.Math.Mul(numbers.Count, Math.Library.Math.Pow(x1, 2));

                sum2 = Math.Library.Math.Add(sum2, Math.Library.Math.Sub(n1,n2));
            }

            double res = Math.Library.Math.Sqrt(Math.Library.Math.Mul(Math.Library.Math.Div(1, Math.Library.Math.Sub(numbers.Count,1)),x1), 2);

            Console.WriteLine(res);
        }
    }
}

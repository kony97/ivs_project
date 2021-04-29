/****************************************************
 * Název projektu: Kalkulačka
 * Soubor: Math.cs
 * Datum: 20.4.2021
 * Poslední změna: 28.4.2021
 * Autor: ASSC tým
 * 
 * Popis: Matematická knihovna
 * 
 ****************************************************
 /**
 * @file Math.cs
 * 
 * @brief Třída Math - knihovna s matematickými operacemi
 * @autor ASSC tým
 */

using System;

namespace Math.Library
{
    public class Math
    {
        /**
         * @brief Absolutní hodnota
         * 
         * @param n1 Číslo, které chceme převézt na absolutní hodnotu
         * @return Číslo v absolutní hodnotě
         */
        public static double Abs(double n1)
        {
            if (n1 < 0) return -n1;
            return n1; 
        }
        
        /**
         * @brief Matematický součet (sčítání)
         * 
         * @param n1 První sčítanec
         * @param n2 Druhý sčítanec
         * @return Součet sčítanců
         */
        public static double Add(double n1, double n2) //sčítání
        {
            return n1 + n2;
        }
        
        /**
         * @brief Matematický podíl (dělení)
         * 
         * @param n1 Dělenec
         * @param n2 Dělitel
         * @return Podíl čísel
         */
        public static double Div(double n1, double n2) //dělení
        {
            if (n2 == 0)
            {
                throw new DivideByZeroException("Nulou nelze dělit");
            }
            return n1 / n2;
        }
        
        /**
         * @brief Faktoriál
         * 
         * @param n Kladné celé číslo
         * @return Faktoriál čísla
         */
        public static long Fact(int n) //faktoriál
        {
            int factorial = 1;
            for(int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        
        /**
         * @brief Matematické součin (násobení)
         * 
         * @param n1 První činitel
         * @param n2 Druhý činitel
         * @return Součin činitelů
         */
        public static double Mul(double n1, double n2)
        {
            return n1 * n2;
        }

        /**
         * @brief N-tá mocnina čísla
         * 
         * @param n1 Základ mocniny
         * @param n2 Mocnina
         * @return Umocněné číslo
         */
        public static double Pow(double n1, double n2) //N1 umocněno na N2
        {
            return System.Math.Pow(n1, n2);
        }
        
        /**
         * @brief N-ta odmocnina čísla
         * 
         * @param n1 Základ odmocniny
         * @param n2 Exponent mocnina
         * @return Odmocněné číslo
         */
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
        
        /**
         * @brief Matematický rozdíl (odečítání)
         * 
         * @param n1 Menšenec
         * @param n2 Menšitel
         * @return Rozdíl čísel
         */
        public static double Sub(double n1, double n2)//odčítá N2 od N1 a vrací N1
        {
            return n1 - n2;
        }
    }
}

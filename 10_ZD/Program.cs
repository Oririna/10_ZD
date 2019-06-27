using System;
using System.Collections.Generic;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ZD
{
    class Program
    {
        static double Sum(double[] M)// нахождение суммы чисел
        {
            string text = "";
            double sum = 0;
            var n = M.Length;
            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                sum += M[i] * M[j];
                text += $"{M[i]}[{i + 1}]*{M[j]}[{j + 1}]";
                if (i < n - 1)
                {
                    text += "+";
                }
                else
                {
                    text += $"={sum}";
                }
            }
            Console.WriteLine(text);
            return sum;
        }
        static double Check(bool mod = true, double inf = 1000) // проверка 
        {
            double to = 0;
            bool flag = true;
            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

            while (flag)
            {
                try
                {
                    string from = Console.ReadLine();
                    to = Double.Parse(from.Replace(',', '.'), CultureInfo.InvariantCulture);
                    flag = false;
                    if (to < 0 && mod)
                    {
                        flag = true;
                    }
                }
                catch (Exception e) // ошибки
                {
                    Console.WriteLine("Ошибка! Повторите ввод: ");
                }
                if (to == 0)
                {
                    flag = true;
                    Console.WriteLine("Ошибка! Повторите ввод: ");
                }
                if (to < 0)
                {
                    flag = true;
                    Console.WriteLine("Ошибка! Повторите ввод: ");
                }
                if (to > inf)
                {
                    flag = true;
                    Console.WriteLine("Ошибка! Повторите ввод: ");
                }
            }
            return to;
        }
        static void Main(string[] args) // ввод
        {
            Console.WriteLine("Введите количство элементов :");
            int n = (int)Check();
            double[] N = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите действительное число :");
                N[i] = Check(false);
            }
            Sum(N);
            Console.ReadKey();
        }
    }
}
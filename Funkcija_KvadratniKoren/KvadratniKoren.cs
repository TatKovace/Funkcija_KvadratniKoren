using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcija_KvadratniKoren
{
    class KvadratniKoren
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This applicaton calls method wich calculate square root of positive part of given number by interpolation.\n");
            Console.Write("Insert number: ");
            double n = Double.Parse(Console.ReadLine());

            string b = "";
            if (n < 0)
                b = b + "i";

            Console.WriteLine("\nSquare root of given number is: " + KvKor(n) + b);

            Console.ReadKey();

            double KvKor (double a)
            {
                if (a < 0)
                    a = a * (-1);
                
                string A = a.ToString();
                double k = 1;

                if (a >= 1)
                {
                    int m = (A.Length + 1) / 2;
                    for (int j = 1; j <= m; j++)
                        k = k * 10;
                }

                double s = 0;
                for (int j = 0; j < 17; j++)
                {
                    for (int i = 0; i <= 10; i++)
                    {
                        if ((s + k * i) * (s + k * i) > a)
                        {
                            s = s + k * (i - 1);
                            break;
                        }
                    }
                    if (s*s == a)
                        break;
                    k = k / 10;
                }
                return s;
            }

        }
    }
}

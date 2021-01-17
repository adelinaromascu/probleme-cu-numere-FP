using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2_FP
{
    class Program
    {
        //Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. 
        //Tratati toate cazurile posibile. 
        static void ecuatie(double a, double b, double c, double d)
        {
            if (d < 0)
            { Console.WriteLine("Delta e mai mic ca 0, nu exista solutii");

            } else if (d == 0)
            {
              Console.WriteLine("X1 = X2 = " + -b / 2 * a);
            } else if (d > 0)
            {
              Console.WriteLine("X1 = " + ((-b + Math.Sqrt(d)) / 2 * a));
              Console.WriteLine("X2 = " + ((-b - Math.Sqrt(d)) / 2 * a));
            }
        }
              static void Main(string[] args)
        { 
            Console.WriteLine("Introdu a:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu b:");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu c:");
            double c = int.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine(d);

            Console.WriteLine(a + "x^2 " + "+ " + b +"x" + " + " + c + " = " + 0);
            ecuatie(a, b, c, d);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_FP
{
    class Program
    {   //Probleme cu numere - Exercitiul 1
        //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        //ax + b = 0 => ax = -b => x = -b/a
       static double ecuatie(double a, double b)
        {
            return -b / a;
        }
        //Se cere a si b, se afiseaza functia si solutia
        static void Main(string[] args)
        {
                
            Console.WriteLine("Introdu a:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu b:");
            double b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + "x " + "+ " + b + " = " + 0);

            Console.WriteLine("Solutia x = -b/a => x = " + ecuatie(a, b)); 
        }
    }
}

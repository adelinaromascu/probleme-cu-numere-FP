using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6_FP
{
    class Program
    {   //Probleme cu numere
        //Problema 6 - Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

        // if (a+b<c) or (b+c<a) or (a+c<b) 

        static bool esteTriunghi(int a, int b, int c)
        {
            if(a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true; 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introdu a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu c:");
            int c = int.Parse(Console.ReadLine());

            if (esteTriunghi(a, b, c))
            {
                Console.WriteLine("Sunt laturile unui triunghi:");
            } else
            {
                Console.WriteLine("Nu sunt laturile unui triunghi:");
            }

        }
    }
}

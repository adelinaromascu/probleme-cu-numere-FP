using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3_FP
{
    class Program
    {   //Problema 3 - Probleme cu numere
        //Determinati daca n se divide cu k, unde n si k sunt date de intrare. 

        static void Main(string[] args)
        {
            Console.WriteLine("Introdu n:");
            double n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu k:");
            double k = int.Parse(Console.ReadLine());

            if(n%k == 0)
            {
                Console.WriteLine(n + " se divide la " + k);
            }
            else
            {
                Console.WriteLine(n + " nu se divide la " + k);
            }
        }
    }
}

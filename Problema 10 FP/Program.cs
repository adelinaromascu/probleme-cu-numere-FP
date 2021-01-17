using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10_FP
{
    class Program
    {   //10.Test de primalitate: determinati daca un numar n este prim.
        //13
        //1,2,3...6.5
        static bool prim(int n)
        {
            int s = 0;

            for(int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                { 
                    s++;
                }
            }
            if (s == 1)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introdu n: ");
            int n = int.Parse(Console.ReadLine());
            if (prim(n))
            {
                Console.WriteLine(n + " este prim");
            } else
            {
                Console.WriteLine(n + " nu este prim");
            }
            
        }
    }
}

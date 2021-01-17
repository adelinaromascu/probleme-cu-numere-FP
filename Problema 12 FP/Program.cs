using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12_FP
{
    class Program
    { //12.Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 

        static int divizibile(int a,int b,int n)
        {
            int s = 0;
            for(int i = a; i <= b; i++)
            {
                if(i%n == 0)
                {
                    s++;
                }
            }
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Intordu n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Numere divizibile la " + n + ": " + divizibile(a, b, n));
            
        }
    }
}

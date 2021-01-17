using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7_FP
{
    class Program
    {   //7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        //int a = 10;
        //int b = 5; faci swap => a = 5; b = 10;
        static void swap(int a,int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " + a + " b = " + b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introdu a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Intordu b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a = " + a + " b = " + b);
            swap(a,b);
        }
    }
}

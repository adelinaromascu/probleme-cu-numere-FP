using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8_FP
{
    class Program
    {   //8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
        //Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introdu b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a = " + a + " b = " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.WriteLine("a = " + a + " b = " + b);
        }
    }
}

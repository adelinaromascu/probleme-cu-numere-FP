using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9_FP
{
    class Program
    {   //9. Afisati toti divizorii numarului n. 

        static void divizori(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if(n%i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("Introdu n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Divizorii lui n sunt: ");
            divizori(n);
        }
    }
}

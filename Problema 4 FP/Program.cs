using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4_FP
{
    class Program
    {//4.Detreminati daca un an y este an bisect. 
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu anul : ");
            int an = int.Parse(Console.ReadLine());
            if (((an % 4 == 0) && (an % 100 != 0)) || (an % 400 == 0)) Console.WriteLine("{0} este an bisect.", an);
            else Console.WriteLine("{0} nu este an bisect.", an);
            Console.ReadLine();
        }
    }
}

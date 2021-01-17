using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_13_FP
{
    class Program
    {  
        //13.Determianti cati ani bisecti sunt intre anii y1 si y2.

        static bool anBisect(int an)
        {
           
            if (((an % 4 == 0) && (an % 100 != 0)) || (an % 400 == 0))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Introdu anul y1 : ");
            int y1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Introdu anul y2 : ");
            int y2 = int.Parse(Console.ReadLine());

            for (int i = y1; i <= y2; i++) {
                if (anBisect(i))
                {
                    s++;
                }
            }

            Console.WriteLine("Ani bisecti intre " + y1 + " si " + y2 + " sunt: " + s);


        }
    }
}

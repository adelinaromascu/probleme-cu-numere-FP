using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_14_FP
{

    class Program
    {
        //Problema 14 FP...Determianti daca un numar n este palindrom. 
        //(un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
        static void Main(string[] args)
        {
            //se declara variabilele de tip intreg
            //variabila n reprezinta numarul introdus de la tastatura
            //variabila m reprezinta copia lui n
            //variabila o reprezinta oglinditul lui n
            int n, m, o = 0;
            Console.Write("Introduceti numarul n = ");    //se citeste nr n
            n = int.Parse(Console.ReadLine());
            m = n;
            while (n != 0)    //construirea oglinditului
            {
                o = o * 10 + n % 10;        // se inverseaza cifra cu cifra numarul n
                n = n / 10;            // // se taie pe rand cifrele lui n
            }
            //verificam daca numarul stocat este egal cu oglinditul
            if (o == m)
                ////testul de palindrom + afisarea mesajului corespunzator
                Console.Write("numarul este palindrom");
            else
                Console.Write("numarul nu este palindrom");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5_FP
{
    class Program
    { //Probleme cu numere
      //Problema 5 - Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
      //1234
      //123
      //12
        static void afiseazaCifra(int n, int pozitie)
        {
            int i = 1;
            int cifraAfisata = 0;
            
             while(i <= pozitie)
            {
                cifraAfisata = n % 10;
                n = n / 10;
                i++;
            }
            Console.WriteLine("de pe pozitia: " + pozitie + " este:" + cifraAfisata);
        }

        static void Main(string[] args)
        {
            int n = 1234;
            int cifra = 2;
            Console.WriteLine("Cifra numarului:" + n);
            afiseazaCifra(n, cifra);
        }
    }
}

using Ispit.Konzola.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PametniTelefon pametniTelefon = new PametniTelefon("Najnovi Model");
            TestirajTelefon(pametniTelefon);
        }

        static void TestirajTelefon(IPametniTelefon telefon)
        {
            Console.WriteLine("Unesite telefonski broj:");
            string telefonskiBroj = Console.ReadLine();

            Console.WriteLine("Unesite URL:");
            string url = Console.ReadLine();

            string rezultatPoziva = telefon.Poziv(telefonskiBroj);
            string rezultatSurfanja = telefon.Surfanje(url);

            Console.WriteLine(rezultatPoziva);
            Console.WriteLine(rezultatSurfanja);
        }
    }
}


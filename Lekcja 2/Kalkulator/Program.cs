using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczba1, liczba2, wynik;
            string liczba1Tekst, liczba2Tekst;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            liczba1Tekst = Console.ReadLine();
            liczba1 = int.Parse(liczba1Tekst);

            Console.WriteLine("Podaj drugą liczbę: ");
            liczba2Tekst = Console.ReadLine();
            liczba2 = int.Parse(liczba2Tekst);

            wynik = liczba1 + liczba2;
            Console.WriteLine($"wynik to {wynik}");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            liczba1Tekst = Console.ReadLine();
            liczba1 = int.Parse(liczba1Tekst);

            Console.WriteLine("Podaj drugą liczbę: ");
            liczba2Tekst = Console.ReadLine();
            liczba2 = int.Parse(liczba2Tekst);

            wynik = liczba1 - liczba2;
            Console.WriteLine($"wynik to {wynik}");

            Console.ReadKey();
        }
    }
}

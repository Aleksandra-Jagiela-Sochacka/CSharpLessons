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
            string dzialanie, odp;

            do
            {
                Console.Write("Jakie działanie chcesz wykonać: ");
                dzialanie = Console.ReadLine();

                liczba1 = PobierzLiczbe();
                liczba2 = PobierzLiczbe();

                if (dzialanie == "+")
                {
                    wynik = Dodaj(liczba1, liczba2);
                    Console.WriteLine($"Wynik to: {wynik}");
                }
                if (dzialanie == "-")
                {
                    wynik = Odejmij(liczba1, liczba2);
                    Console.WriteLine($"Wynik to: {wynik}");
                }
                if (dzialanie == "*")
                {
                    wynik = Pomnóż(liczba1, liczba2);
                    Console.WriteLine($"Wynik to: {wynik}");
                }
                if (dzialanie == ":")
                {
                    if (liczba2 == 0)
                    {
                        Console.WriteLine("Nie mozna dzielic przez 0");
                    }
                    else
                    {
                        wynik = Podziel(liczba1, liczba2);
                        Console.WriteLine($"Wynik to: {wynik}");
                    }
                }
                if (dzialanie == "max")
                {
                    wynik = Max(liczba1, liczba2);
                    Console.WriteLine($"Makstmalna liczba to: {wynik}");
                }

                Console.WriteLine("Czy chcesz kontynuować: ");
                odp = Console.ReadLine();

            } while (odp == "tak");              
        }

        static int PobierzLiczbe()
        {
            Console.Write("Podaj liczbe: ");
            string liczbaTekst = Console.ReadLine();
            return int.Parse(liczbaTekst); 
        }

        static int Dodaj(int liczba1, int liczba2)
        {
            int wynik = liczba1 + liczba2;
            return wynik;
        }

        static int Odejmij(int liczba1, int liczba2)
        {
            int wynik = liczba1 - liczba2;
            return wynik;
        }

        static int Pomnóż(int liczba1, int liczba2)
        {
            int wynik = liczba1 * liczba2;
            return wynik;
        }

        static int Podziel(int liczba1, int liczba2)
        {
            int wynik = liczba1 / liczba2;
            return wynik;         
        }

        static int Max(int liczba1, int liczba2)
        {
            if (liczba1 > liczba2)
            {
                return liczba1;
            }
            else
            {
                return liczba2;
            }
        }
    }
}

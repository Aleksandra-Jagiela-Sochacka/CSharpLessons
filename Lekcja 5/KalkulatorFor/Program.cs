﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int ileRazy, liczba1, liczba2, wynik;
            string ileRazyTekst, działanie, liczba1Tekst, liczba2Tekst;

            Console.Write("Ile razy chcesz wykonać Kalkulator: ");
            ileRazyTekst = Console.ReadLine();
            ileRazy = int.Parse(ileRazyTekst);

            for (int i = 0; i < ileRazy; i++)
            {
                Console.Write("Co chcesz zrobić (+ - * :) ");
                działanie = Console.ReadLine();

                Console.Write("Podaj pierwszą liczbę: ");
                liczba1Tekst = Console.ReadLine();
                if (!int.TryParse(liczba1Tekst, out liczba1))
                    Console.WriteLine("Podałeś niepoprawną wartość. liczna1 = 0");

                Console.Write("Podaj drugą liczbę: ");
                liczba2Tekst = Console.ReadLine();
                if (!int.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Podałeś niepoprawną wartość. liczna2 = 0");

                if (działanie == "+")
                {
                    wynik = liczba1 + liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (działanie == "-")
                {
                    wynik = liczba1 - liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (działanie == "*")
                {
                    wynik = liczba1 * liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (działanie == ":")
                {
                    if (liczba2 == 0)
                    {
                        Console.WriteLine("Nie dzielimy przez zero");
                    }
                    else
                    {
                        wynik = liczba1 / liczba2;
                        Console.WriteLine($"wynik: {wynik}");
                    }
                }
                else
                {
                    Console.WriteLine("Nie wiem co chcesz zrobić");
                }
            }

            Console.ReadKey();
        }
    }
}

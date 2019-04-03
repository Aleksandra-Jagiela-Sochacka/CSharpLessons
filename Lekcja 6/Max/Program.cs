using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
{
    class Program
    {
        static void Main(string[] args)
        {
            double liczba1, liczba2, max;
            string liczba1Tekst, liczba2Tekst, odp;

            Console.Write("Podaj liczbę: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Podałeś niepoprawną wartość. liczna1 = 0");

            max = liczba1;

            Console.Write("Czy chcesz podać kolejną liczbę: ");
            odp = Console.ReadLine();

            while (odp == "t")
            {
                Console.Write("Podaj liczbę: ");
                liczba2Tekst = Console.ReadLine();
                if (!double.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Podałeś niepoprawną wartość. liczna2 = 0");

                max = Max(max, liczba2);

                Console.Write("Czy chcesz podać kolejną liczbę");
                odp = Console.ReadLine();
            }

            Console.WriteLine($"max: {max}");
            Console.ReadKey();
        }

        static double Max(double liczba1, double liczba2)
        {
            double max = liczba1;

            if (liczba2 > liczba1)
            {
                max = liczba2;
            }

            return max;
        }
    }
}

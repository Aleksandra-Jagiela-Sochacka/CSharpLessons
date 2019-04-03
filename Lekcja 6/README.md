# Lekcja 6

Zajęcia zaczęliśmy od prostego programu porównującego dwie liczby

```csharp
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
            double liczba1, liczba2;
            string liczba1Tekst, liczba2Tekst;

            Console.Write("Podaj pierwszą liczbę: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Podałeś niepoprawną wartość. liczna1 = 0");

            Console.Write("Podaj drugą liczbę: ");
            liczba2Tekst = Console.ReadLine();
            if (!double.TryParse(liczba2Tekst, out liczba2))
                Console.WriteLine("Podałeś niepoprawną wartość. liczna2 = 0");

            if(liczba1 > liczba2)
            {
                Console.WriteLine($"{liczba1} > {liczba2}");
            }
            else if( liczba1 < liczba2)
            {
                Console.WriteLine($"{liczba1} < {liczba2}");
            }
            else
            {
                Console.WriteLine($"{liczba1} == {liczba2}");
            }

            Console.ReadKey();
        }
    }
}
```
Następnie edytowaliśmy ten program zmieniając go na program szukający maksimum 
z dowolnej ilości liczb (użytkownik decyduje w trakcje ile liczb chce porównywać)

```csharp
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
                             
                if(liczba2 > max)
                {
                    max = liczba2;
                }              

                Console.Write("Czy chcesz podać kolejną liczbę");
                odp = Console.ReadLine();
            }

            Console.WriteLine($"max: {max}");
            Console.ReadKey();
        }
    }
}
```

Na koniec zajęć wyrzuciliśmy funkcję poza "meina"

```csharp
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
```

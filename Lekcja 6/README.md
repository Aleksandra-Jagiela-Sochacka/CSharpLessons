# Lekcja 6

Zajêcia zaczêliœmy od prostego programu porównuj¹cego dwie liczby

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

            Console.Write("Podaj pierwsz¹ liczbê: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna1 = 0");

            Console.Write("Podaj drug¹ liczbê: ");
            liczba2Tekst = Console.ReadLine();
            if (!double.TryParse(liczba2Tekst, out liczba2))
                Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna2 = 0");

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
Nastêpnie edytowaliœmy ten program zmieniaj¹c go na program szukaj¹cy maksimum 
z dowolnej iloœci liczb (u¿ytkownik decyduje w trakcje ile liczb chce porównywaæ)

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

            Console.Write("Podaj liczbê: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna1 = 0");

            max = liczba1;

            Console.Write("Czy chcesz podaæ kolejn¹ liczbê: ");
            odp = Console.ReadLine();

            while (odp == "t")
            {
                Console.Write("Podaj liczbê: ");
                liczba2Tekst = Console.ReadLine();
                if (!double.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna2 = 0");
                             
                if(liczba2 > max)
                {
                    max = liczba2;
                }              

                Console.Write("Czy chcesz podaæ kolejn¹ liczbê");
                odp = Console.ReadLine();
            }

            Console.WriteLine($"max: {max}");
            Console.ReadKey();
        }
    }
}
```

Na koniec zajêæ wyrzuciliœmy funkcjê poza "meina"

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

            Console.Write("Podaj liczbê: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna1 = 0");

            max = liczba1;

            Console.Write("Czy chcesz podaæ kolejn¹ liczbê: ");
            odp = Console.ReadLine();

            while (odp == "t")
            {
                Console.Write("Podaj liczbê: ");
                liczba2Tekst = Console.ReadLine();
                if (!double.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna2 = 0");

                max = Max(max, liczba2);

                Console.Write("Czy chcesz podaæ kolejn¹ liczbê");
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

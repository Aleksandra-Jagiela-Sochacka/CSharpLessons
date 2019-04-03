# Lekcja 6

Zaj�cia zacz�li�my od prostego programu por�wnuj�cego dwie liczby

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

            Console.Write("Podaj pierwsz� liczb�: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Poda�e� niepoprawn� warto��. liczna1 = 0");

            Console.Write("Podaj drug� liczb�: ");
            liczba2Tekst = Console.ReadLine();
            if (!double.TryParse(liczba2Tekst, out liczba2))
                Console.WriteLine("Poda�e� niepoprawn� warto��. liczna2 = 0");

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
Nast�pnie edytowali�my ten program zmieniaj�c go na program szukaj�cy maksimum 
z dowolnej ilo�ci liczb (u�ytkownik decyduje w trakcje ile liczb chce por�wnywa�)

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

            Console.Write("Podaj liczb�: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Poda�e� niepoprawn� warto��. liczna1 = 0");

            max = liczba1;

            Console.Write("Czy chcesz poda� kolejn� liczb�: ");
            odp = Console.ReadLine();

            while (odp == "t")
            {
                Console.Write("Podaj liczb�: ");
                liczba2Tekst = Console.ReadLine();
                if (!double.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Poda�e� niepoprawn� warto��. liczna2 = 0");
                             
                if(liczba2 > max)
                {
                    max = liczba2;
                }              

                Console.Write("Czy chcesz poda� kolejn� liczb�");
                odp = Console.ReadLine();
            }

            Console.WriteLine($"max: {max}");
            Console.ReadKey();
        }
    }
}
```

Na koniec zaj�� wyrzucili�my funkcj� poza "meina"

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

            Console.Write("Podaj liczb�: ");
            liczba1Tekst = Console.ReadLine();
            if (!double.TryParse(liczba1Tekst, out liczba1))
                Console.WriteLine("Poda�e� niepoprawn� warto��. liczna1 = 0");

            max = liczba1;

            Console.Write("Czy chcesz poda� kolejn� liczb�: ");
            odp = Console.ReadLine();

            while (odp == "t")
            {
                Console.Write("Podaj liczb�: ");
                liczba2Tekst = Console.ReadLine();
                if (!double.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Poda�e� niepoprawn� warto��. liczna2 = 0");

                max = Max(max, liczba2);

                Console.Write("Czy chcesz poda� kolejn� liczb�");
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

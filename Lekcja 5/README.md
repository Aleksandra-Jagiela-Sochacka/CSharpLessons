# Lekcja 5

Poznaliœmy trzy pêtle `for`, `while` i `do while`.

- Pêtla `for` jest wykorzystywana gdy u¿ytkownik z góry wie ile razy ma 
siê wykonaæ instrukcja. Zatem u¿ytkownik z góry deklaruje ile razy pêtla 
ma siê wykonaæ.
```csharp
 for (warunek pocz¹tkowy, warunek koñcowy, zmiana)
 {
    #ci¹g instrukcji
 }
``` 

na zajêciach zmodyfikowaliœmy nasz kalkulator. Wpierw pytamy u¿ytkownika
ile razy chce go wywo³aæ a nastêpnie wk³adamy ca³y kalkulator w pêtle `for`

```csharp
using System;
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
            string ileRazyTekst, dzia³anie, liczba1Tekst, liczba2Tekst;

            Console.Write("Ile razy chcesz wykonaæ Kalkulator: ");
            ileRazyTekst = Console.ReadLine();
            ileRazy = int.Parse(ileRazyTekst);

            for (int i = 0; i < ileRazy; i++)
            {
                Console.Write("Co chcesz zrobiæ (+ - * :) ");
                dzia³anie = Console.ReadLine();

                Console.Write("Podaj pierwsz¹ liczbê: ");
                liczba1Tekst = Console.ReadLine();
                if (!int.TryParse(liczba1Tekst, out liczba1))
                    Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna1 = 0");

                Console.Write("Podaj drug¹ liczbê: ");
                liczba2Tekst = Console.ReadLine();
                if (!int.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna2 = 0");

                if (dzia³anie == "+")
                {
                    wynik = liczba1 + liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (dzia³anie == "-")
                {
                    wynik = liczba1 - liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (dzia³anie == "*")
                {
                    wynik = liczba1 * liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (dzia³anie == ":")
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
                    Console.WriteLine("Nie wiem co chcesz zrobiæ");
                }
            }

            Console.ReadKey();
        }
    }
}
```


- Pêtla `while` jest wykorzystywana gdy u¿ytkownik w trakcje programu chce 
decydowaæ o jego powtarzalnoœci, gdy mamy pêtlê `while` mo¿e siê ona nie 
wykonaæ ani razu.
```csharp
 while(warunek)
 {
    #ci¹g instrukcji
 }
``` 

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzescWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string odp;

            Console.Write("Czy chcesz siê przywitaæ: ");
            odp = Console.ReadLine();

            while (odp == "tak" || odp == "TAK" || odp == "Tak")
            {
                Console.WriteLine("Czeœæ");
                Console.Write("Czy chcesz siê przywitaæ: ");
                odp = Console.ReadLine();
            }
        }
    }
}
```

- Pêtla `do while` wykorzystywana jest gdy u¿ytkownik chce 
decydowaæ o jej powtarzalnoœci w trakcje programu, jednak
jest to pêtla, która musi siê wykonaæ chocia¿ jeden raz.

``` csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CzescDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string odp;
            do
            {
                Console.WriteLine("Czeœæ");
                Console.Write("Czy chcesz siê przywitaæ jeszcze raz: ");
                odp = Console.ReadLine();
            }
            while (odp == "tak" || odp == "TAK" || odp == "Tak");
        }
    }
}

```




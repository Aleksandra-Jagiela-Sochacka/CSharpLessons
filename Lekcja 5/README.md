# Lekcja 5

Poznali�my trzy p�tle `for`, `while` i `do while`.

- P�tla `for` jest wykorzystywana gdy u�ytkownik z g�ry wie ile razy ma 
si� wykona� instrukcja. Zatem u�ytkownik z g�ry deklaruje ile razy p�tla 
ma si� wykona�.
```csharp
 for (warunek pocz�tkowy, warunek ko�cowy, zmiana)
 {
    #ci�g instrukcji
 }
``` 

na zaj�ciach zmodyfikowali�my nasz kalkulator. Wpierw pytamy u�ytkownika
ile razy chce go wywo�a� a nast�pnie wk�adamy ca�y kalkulator w p�tle `for`

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
            string ileRazyTekst, dzia�anie, liczba1Tekst, liczba2Tekst;

            Console.Write("Ile razy chcesz wykona� Kalkulator: ");
            ileRazyTekst = Console.ReadLine();
            ileRazy = int.Parse(ileRazyTekst);

            for (int i = 0; i < ileRazy; i++)
            {
                Console.Write("Co chcesz zrobi� (+ - * :) ");
                dzia�anie = Console.ReadLine();

                Console.Write("Podaj pierwsz� liczb�: ");
                liczba1Tekst = Console.ReadLine();
                if (!int.TryParse(liczba1Tekst, out liczba1))
                    Console.WriteLine("Poda�e� niepoprawn� warto��. liczna1 = 0");

                Console.Write("Podaj drug� liczb�: ");
                liczba2Tekst = Console.ReadLine();
                if (!int.TryParse(liczba2Tekst, out liczba2))
                    Console.WriteLine("Poda�e� niepoprawn� warto��. liczna2 = 0");

                if (dzia�anie == "+")
                {
                    wynik = liczba1 + liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (dzia�anie == "-")
                {
                    wynik = liczba1 - liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (dzia�anie == "*")
                {
                    wynik = liczba1 * liczba2;
                    Console.WriteLine($"wynik: {wynik}");
                }
                else if (dzia�anie == ":")
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
                    Console.WriteLine("Nie wiem co chcesz zrobi�");
                }
            }

            Console.ReadKey();
        }
    }
}
```


- P�tla `while` jest wykorzystywana gdy u�ytkownik w trakcje programu chce 
decydowa� o jego powtarzalno�ci, gdy mamy p�tl� `while` mo�e si� ona nie 
wykona� ani razu.
```csharp
 while(warunek)
 {
    #ci�g instrukcji
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

            Console.Write("Czy chcesz si� przywita�: ");
            odp = Console.ReadLine();

            while (odp == "tak" || odp == "TAK" || odp == "Tak")
            {
                Console.WriteLine("Cze��");
                Console.Write("Czy chcesz si� przywita�: ");
                odp = Console.ReadLine();
            }
        }
    }
}
```

- P�tla `do while` wykorzystywana jest gdy u�ytkownik chce 
decydowa� o jej powtarzalno�ci w trakcje programu, jednak
jest to p�tla, kt�ra musi si� wykona� chocia� jeden raz.

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
                Console.WriteLine("Cze��");
                Console.Write("Czy chcesz si� przywita� jeszcze raz: ");
                odp = Console.ReadLine();
            }
            while (odp == "tak" || odp == "TAK" || odp == "Tak");
        }
    }
}

```




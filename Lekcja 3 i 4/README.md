# Lekcja 3 i 4

Na zaj�ciach starali�my si� stworzy� program kt�ry bra� by pod uwag�, �e u�ytkownik
z niego korzystaj�cy nie naci�nie tego co by�my chcieli. Wykorzystali�my w nim 
zmienne typu `bool` oraz instrukcj� warunkow� `if`.
Instrukcje t� u�yli�my r�wnie� do stworzenia podstawowego kalkulatora oraz do 
wykonania dzielenia dw�ch liczb. Gdy� przy dzieleniu nale�y pami�ta� aby nie 
dzieli� przez zero.

 - Instrukcja warunkowa - wariant 1

```csharp
if (warunek)
{
    #cj�g instrukcij
}
```

 - Instrukcja warunkowa - wariant 2
 
```csharp
if (warunek)
{
    #cj�g instrukcij
}
else
{
    #cj�g instrukcij
}
```
- Instrukcja warunkowa - wariant 3
 
```csharp
if (warunek)
{
    #cj�g instrukcij
}
if else (warunek)
{
    #cj�g instrukcij
}
else
{
    #cj�g instrukcij
}
```


 - Pobranie dw�ch liczb i sprawdzenie czy u�ytkownik podaje to co trzeba je�eli nie wy�wietla
tekst �e zamieni to na zero.
```csharp
 int liczba1, liczba2;
 string liczba1Tekst, liczba2Tekst;

 Console.WriteLine("Podaj pierwsz� liczb�: ");
 liczba1Tekst = Console.ReadLine();
 if (!int.TryParse(liczba1Tekst, out liczba1))
     Console.WriteLine("Poda�e� niepoprawn� warto��. liczna1 = 0");

 Console.WriteLine("Podaj drug� liczb�: ");
 liczba2Tekst = Console.ReadLine();
 if (!int.TryParse(liczba2Tekst, out liczba2))
     Console.WriteLine("Poda�e� niepoprawn� warto��. liczna2 = 0");
```

- instrukcja warunkowa dla dzielenia dw�ch liczb

```csharp
 int liczba1, liczba2, wynik;
 string liczba1Tekst, liczba2Tekst;

 Console.WriteLine("Podaj pierwsz� liczb�: ");
 liczba1Tekst = Console.ReadLine();
 if (!int.TryParse(liczba1Tekst, out liczba1))
     Console.WriteLine("Poda�e� niepoprawn� warto��. liczna1 = 0");

 Console.WriteLine("Podaj drug� liczb�: ");
 liczba2Tekst = Console.ReadLine();
 if (!int.TryParse(liczba2Tekst, out liczba2))
     Console.WriteLine("Poda�e� niepoprawn� warto��. liczna2 = 0");

 if (liczba2 == 0)
 {
     Console.WriteLine("Nie dzielimy przez zero");
 }
 else
 {
     wynik = liczba1 / liczba2;
     Console.WriteLine($"wynik: {wynik}");
 }
```

- kalkulator za pomoc� instrukcji warunkowej

```csharp
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
            string dzia�anie, liczba1Tekst, liczba2Tekst;

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
                        
            Console.ReadKey();
        }
    }
}
```

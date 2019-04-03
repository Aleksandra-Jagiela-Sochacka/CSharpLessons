# Lekcja 2

Zajêcja zaczeliœmy od stworzenia pierwszego projektu. Wybieraliœmy jêzyk: *C#*, 
platformê: *Windows*, typ aplikacji: *Console* i framework: *.NET Framework*. 
Po wybraniu nazwy projektu i utworzeniu go, omuwiliœmy jego strukturê.

Na zajêciach zaczeliœmy tworzyæ kalkulator. Skorzystaliœmy z takich poleceñ jak :
- polecenie wyœwietlenia tekstu 
```csharp
Console.WriteLine("Podaj pierwsz¹ liczbê");
```
- pobrania tekstu z konsoli 
```csharp
Console.ReadLine();
```

- "magiczna" zamiana tekstu z konsoli (string) na liczbê ca³kowit¹ (int)
```csharp
int.Parse("33");
```

Na zajêcjach uda³o nam siê stworzyæ program który dodawa³ i odejmowa³ dwie liczby
ca³kowite pierew pytaj¹c o nie.

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
            string liczba1Tekst, liczba2Tekst;

            Console.WriteLine("Podaj pierwsz¹ liczbê: ");
            liczba1Tekst = Console.ReadLine();
            liczba1 = int.Parse(liczba1Tekst);

            Console.WriteLine("Podaj drug¹ liczbê: ");
            liczba2Tekst = Console.ReadLine();
            liczba2 = int.Parse(liczba2Tekst);

            wynik = liczba1 + liczba2;
            Console.WriteLine($"wynik to {wynik}");

            Console.WriteLine("Podaj pierwsz¹ liczbê: ");
            liczba1Tekst = Console.ReadLine();
            liczba1 = int.Parse(liczba1Tekst);

            Console.WriteLine("Podaj drug¹ liczbê: ");
            liczba2Tekst = Console.ReadLine();
            liczba2 = int.Parse(liczba2Tekst);

            wynik = liczba1 - liczba2;
            Console.WriteLine($"wynik to {wynik}");

            Console.ReadKey();
        }
    }
}

```
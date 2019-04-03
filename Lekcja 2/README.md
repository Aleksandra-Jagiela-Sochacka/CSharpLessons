# Lekcja 2

Zaj�cja zaczeli�my od stworzenia pierwszego projektu. Wybierali�my j�zyk: *C#*, 
platform�: *Windows*, typ aplikacji: *Console* i framework: *.NET Framework*. 
Po wybraniu nazwy projektu i utworzeniu go, omuwili�my jego struktur�.

Na zaj�ciach zaczeli�my tworzy� kalkulator. Skorzystali�my z takich polece� jak :
- polecenie wy�wietlenia tekstu 
```csharp
Console.WriteLine("Podaj pierwsz� liczb�");
```
- pobrania tekstu z konsoli 
```csharp
Console.ReadLine();
```

- "magiczna" zamiana tekstu z konsoli (string) na liczb� ca�kowit� (int)
```csharp
int.Parse("33");
```

Na zaj�cjach uda�o nam si� stworzy� program kt�ry dodawa� i odejmowa� dwie liczby
ca�kowite pierew pytaj�c o nie.

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

            Console.WriteLine("Podaj pierwsz� liczb�: ");
            liczba1Tekst = Console.ReadLine();
            liczba1 = int.Parse(liczba1Tekst);

            Console.WriteLine("Podaj drug� liczb�: ");
            liczba2Tekst = Console.ReadLine();
            liczba2 = int.Parse(liczba2Tekst);

            wynik = liczba1 + liczba2;
            Console.WriteLine($"wynik to {wynik}");

            Console.WriteLine("Podaj pierwsz� liczb�: ");
            liczba1Tekst = Console.ReadLine();
            liczba1 = int.Parse(liczba1Tekst);

            Console.WriteLine("Podaj drug� liczb�: ");
            liczba2Tekst = Console.ReadLine();
            liczba2 = int.Parse(liczba2Tekst);

            wynik = liczba1 - liczba2;
            Console.WriteLine($"wynik to {wynik}");

            Console.ReadKey();
        }
    }
}

```
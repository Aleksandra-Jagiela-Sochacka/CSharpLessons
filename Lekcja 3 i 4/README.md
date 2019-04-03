# Lekcja 3 i 4

Na zajêciach staraliœmy siê stworzyæ program który bra³ by pod uwagê, ¿e u¿ytkownik
z niego korzystaj¹cy nie naciœnie tego co byœmy chcieli. Wykorzystaliœmy w nim 
zmienne typu `bool` oraz instrukcjê warunkow¹ `if`.
Instrukcje tê u¿yliœmy równie¿ do stworzenia podstawowego kalkulatora oraz do 
wykonania dzielenia dwóch liczb. Gdy¿ przy dzieleniu nale¿y pamiêtaæ aby nie 
dzieliæ przez zero.

 - Instrukcja warunkowa - wariant 1

```csharp
if (warunek)
{
    #cj¹g instrukcij
}
```

 - Instrukcja warunkowa - wariant 2
 
```csharp
if (warunek)
{
    #cj¹g instrukcij
}
else
{
    #cj¹g instrukcij
}
```
- Instrukcja warunkowa - wariant 3
 
```csharp
if (warunek)
{
    #cj¹g instrukcij
}
if else (warunek)
{
    #cj¹g instrukcij
}
else
{
    #cj¹g instrukcij
}
```


 - Pobranie dwóch liczb i sprawdzenie czy u¿ytkownik podaje to co trzeba je¿eli nie wyœwietla
tekst ¿e zamieni to na zero.
```csharp
 int liczba1, liczba2;
 string liczba1Tekst, liczba2Tekst;

 Console.WriteLine("Podaj pierwsz¹ liczbê: ");
 liczba1Tekst = Console.ReadLine();
 if (!int.TryParse(liczba1Tekst, out liczba1))
     Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna1 = 0");

 Console.WriteLine("Podaj drug¹ liczbê: ");
 liczba2Tekst = Console.ReadLine();
 if (!int.TryParse(liczba2Tekst, out liczba2))
     Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna2 = 0");
```

- instrukcja warunkowa dla dzielenia dwóch liczb

```csharp
 int liczba1, liczba2, wynik;
 string liczba1Tekst, liczba2Tekst;

 Console.WriteLine("Podaj pierwsz¹ liczbê: ");
 liczba1Tekst = Console.ReadLine();
 if (!int.TryParse(liczba1Tekst, out liczba1))
     Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna1 = 0");

 Console.WriteLine("Podaj drug¹ liczbê: ");
 liczba2Tekst = Console.ReadLine();
 if (!int.TryParse(liczba2Tekst, out liczba2))
     Console.WriteLine("Poda³eœ niepoprawn¹ wartoœæ. liczna2 = 0");

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

- kalkulator za pomoc¹ instrukcji warunkowej

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
            string dzia³anie, liczba1Tekst, liczba2Tekst;

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
                        
            Console.ReadKey();
        }
    }
}
```

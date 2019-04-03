# Lekcja 1

Na zajęciach instalowaliśmy program Visual Studio 2019.
Zainstalowaliśmy narzędzia potrzebne do programowania w C#, 
oraz omówiliśmy inne narzędzia które również wchodzą 
w skład środowiska Visual Studio

Jeżeli ktoś chce zainstalować to oprogramowanie w domu, może je pobrać ze strony : 
https://visualstudio.microsoft.com/pl/downloads/ 
Do użytku domowego instalujemy bezpłatną wersję Community(Społeczność)

Na zajęciach również mówiłam o tym że jeżeli tworzymy program który ma zapamiętywać
pewne dane, musimy pamiętać o tym, że wcześniej musimy mu zadeklarować gdzie 
mają być przechowywane gdyż można powiedzieć komputer potrzebuje na każdą daną *"pudełko"*,
 na każdą pojedynczą daną osobne *"pudełko"*. Zatem jak chcemy dodać dwie liczby
musimy mieć *"pudełek"* aż trzy. Pierwsze na pierwszą zmienną, drugie na drugą zmienną,
 a trzecie na trzecią liczbę która powstanie z sumowania dwóch poprzednich.

Deklarując zmienną musimy podać nazwę *"pudełka"* oraz jego typ oznaczający co będzie przechowywane.
Zatem jak będziemy chcieli używać liczby całkowitej np. 2 to deklarujemy
```csharp
int liczba = 1;
```  
Inne typy które poznaliśmy to

```csharp
bool	 #typ logiczny prawda/fałsz

byte	 #liczby całkowite z zakresu od 0 do 255
sbyte    #liczby całkowite z zakresu od -128 do 127

short	 #liczby całkowite z zakresu od -32,768 do 32,767
int	 #liczby całkowite z zakresu od -2,147,483,648 do 2,147,483,647
long 	 #liczby całkowite z zakresu od -9,223,372,036,854,775,808 do 9,223,372,036,854,775,807

uint	 #liczby całkowite z zakresu od 0 do 4,294,967,295
ushort	 #liczby całkowite z zakresu od 0 do 65,535
ulong 	 #liczby całkowite z zakresu od 0 do 18,446,744,073,709,551,615

double	 #liczby rzeczywiste z zakresu od ±5.0 × 10^−324 do ±1.7 × 10^308
decimal  #liczby rzeczywiste z zakresu od ±1.0 x 10^-28 do ±7.9228 x 10^28
float	 #liczby rzeczywiste z zakresu od ±1.5 x 10^−45 do ±3.4 x 10^38

char	 #typ znakowy, pojedynczy znak
string	 #typ znakowy, ciąg znaków
```  



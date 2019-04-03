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
                Console.WriteLine("Cześć");
                Console.Write("Czy chcesz się przywitać jeszcze raz: ");
                odp = Console.ReadLine();
            }
            while (odp == "tak" || odp == "TAK" || odp == "Tak");
        }
    }
}

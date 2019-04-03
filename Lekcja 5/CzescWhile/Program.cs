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

            Console.Write("Czy chcesz się przywitać: ");
            odp = Console.ReadLine();

            while (odp == "tak" || odp == "TAK" || odp == "Tak")
            {
                Console.WriteLine("Cześć");
                Console.Write("Czy chcesz się przywitać: ");
                odp = Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveDegiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor onRenk = ConsoleColor.White;
            ConsoleColor ArkaRenk = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ArkaRenk;
            Console.ForegroundColor = onRenk;


            int x = 100;
            decimal y = 100;
            bool deger = true;
            Console.WriteLine(x);
            Console.ReadKey();

        }
    }
}

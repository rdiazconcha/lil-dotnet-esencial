using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bcl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione la opción");

            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Paint");

            var option = Console.ReadLine();

            if (option == "1")
            {
                Process.Start("calc");
            }
            else
            {
                Process.Start("mspaint");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposdinamicos
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new
            {
                Nombre = ".NET esencial",
                Autor ="Rodrigo Díaz Concha",
                Descripcion = "Curso de .NET esencial"
            };

            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Autor);
            Console.WriteLine(c.Descripcion);
        }
    }
}

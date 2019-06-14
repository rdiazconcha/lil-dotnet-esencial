using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gc
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<int>();

            for (int i = 0; i < 100000000; i++)
            {
                lista.Add(int.MaxValue);
            }

            Console.WriteLine("Lista creada. Presione para limpiar la lista");
            Console.ReadLine();

            lista.Clear();
            lista = null;

            Console.WriteLine("Lista borrada.  Presione para invocar el GC");
            Console.ReadLine();

            GC.Collect();

            Console.WriteLine("GC invocado");
            Console.ReadLine();
        }
    }
}

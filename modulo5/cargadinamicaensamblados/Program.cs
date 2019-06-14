using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace cargadinamicaensamblados
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("EnsambladoDinamico.dll");

            var mitipo = assembly.GetType("MiTipo");

            var instancia = Activator.CreateInstance(mitipo);

            mitipo.GetField("numero").SetValue(instancia, 1000);

            Console.WriteLine(mitipo.GetField("numero").GetValue(instancia));
        }
    }
}

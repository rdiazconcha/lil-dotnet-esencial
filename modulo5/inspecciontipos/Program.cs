using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inspecciontipos
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona();
            var t = persona.GetType();
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.Name);
            Console.WriteLine(t.IsSealed);
            Console.WriteLine(t.IsAbstract);
            Console.WriteLine(t.IsClass);

            var metodos = t.GetMethods();
            foreach (var m in metodos)
            {
                if (m.Name == "Saludar")
                {
                    m.Invoke(persona, new[] { "LinkedIn Learning" });
                }
                Console.WriteLine(m.Name);
            }

            Console.WriteLine();
            Console.WriteLine();

            var propiedades = t.GetProperties();

            foreach (var p in propiedades)
            {
                Console.WriteLine(p.Name);
            }

            Console.WriteLine();
            Console.WriteLine();

            var campos = t.GetFields();
            foreach (var c in campos)
            {
                Console.WriteLine(c.Name);
            }
        }
    }

    sealed class Persona
    {
        public int numero;
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }
    }
}

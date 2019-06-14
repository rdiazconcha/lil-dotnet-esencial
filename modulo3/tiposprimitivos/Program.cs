using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposprimitivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(default(System.Int16));
            Console.WriteLine(default(System.Int32));
            Console.WriteLine(default(System.Int64));
            Console.WriteLine(default(System.DateTime));
            Console.WriteLine(default(System.Boolean));
            Console.WriteLine(default(System.String));
            Console.WriteLine("MaxValues...");
            Console.WriteLine(System.Int16.MaxValue);
            Console.WriteLine(System.Int32.MaxValue);
            Console.WriteLine(System.Int64.MaxValue);
            Console.WriteLine(System.DateTime.MaxValue);

            int i = 10;
            bool b = true;
            string s = "Ejemplo";
        }
    }
}

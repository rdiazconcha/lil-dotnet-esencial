using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposporvaloryreferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            data.Number = 10;

            var data2 = data;
            Console.WriteLine(data.Number);
            Console.WriteLine(data2.Number);

            Console.WriteLine();

            data2.Number = 20;
            Console.WriteLine(data.Number);
            Console.WriteLine(data2.Number);
        }
    }

    class Data
    {
        public int Number;
    }
}

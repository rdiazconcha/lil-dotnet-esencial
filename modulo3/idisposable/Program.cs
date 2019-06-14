using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idisposable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = File.OpenRead(@"C:\archivo.txt")
            {

            } //...
        }
    }
}

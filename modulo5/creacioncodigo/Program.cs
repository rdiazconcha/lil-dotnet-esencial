using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;

namespace creacioncodigo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var ensamblado = new AssemblyName("EnsambladoDinamico");
            //var ab = AssemblyBuilder.DefineDynamicAssembly(ensamblado, AssemblyBuilderAccess.RunAndSave);
            //var mb = ab.DefineDynamicModule(ensamblado.Name, ensamblado.Name + ".dll");
            //var tb = mb.DefineType("MiTipo", TypeAttributes.Public);
            //var fb = tb.DefineField("numero", typeof(int), FieldAttributes.Public);

            ////...

            //tb.CreateType();

            //ab.Save(ensamblado.Name + ".dll");

            MiTipo x = new MiTipo();
            x.numero = 10;
            Console.WriteLine(x.numero);
        }
    }
}

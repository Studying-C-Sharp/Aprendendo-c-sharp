using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRefOut
{
    class teste
    {
        public void MetOut(ref int parametro, out int resultado)
        {
            parametro++;
            Console.WriteLine(parametro);
            resultado = parametro + 100;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryasExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysDimensionais arr = new ArraysDimensionais();
            arr.ImprimirArray();
            arr.MostrarArrayBi();
            arr.PreencherArrayBI();
            arr.ImplimirJaggedArray();
            Console.ReadKey();
        }
    }
}

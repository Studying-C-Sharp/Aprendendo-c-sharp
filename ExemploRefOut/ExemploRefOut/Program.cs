using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int argValor = 10, res;
            teste Class1 = new teste();
            //chama metodo enviando uma referencia e uma saida
            Class1.MetOut(ref argValor, out res);
            //imprime na tela
            Console.WriteLine(argValor);
            Console.WriteLine(res);
            //pausa o console aguardando apertar qualquer tecla
            Console.ReadKey();

        }
    }
}

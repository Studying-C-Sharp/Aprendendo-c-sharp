using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomandoNumerosRecebidos
{
    class SomandoNumerosRecebidos
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 0;
            b = 0;

            String aux;

            Console.Write("Entre com valor A ");
            aux = Console.ReadLine();
            a = Convert.ToInt32(aux) ;

            Console.Write("Entre com valor B ");
            aux = Console.ReadLine();
            b = Convert.ToInt32(aux);

            Console.WriteLine("a soma de A e B é: " + (a+b));
            Console.WriteLine("a subtração de A e B é: " + (a-b));


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            String s;

            Console.WriteLine("Digite um numero: ");
            s=Console.ReadLine();
            a = Convert.ToInt32(s);

            Console.WriteLine("Digete outro numero: ");
            s = Console.ReadLine();
            b = Convert.ToInt32(s);

            Teste t1 = new Teste();
            Teste t2 = new Teste(a, b);

            Console.WriteLine("termino do programa...");
            Console.ReadKey();

        }
    }
}

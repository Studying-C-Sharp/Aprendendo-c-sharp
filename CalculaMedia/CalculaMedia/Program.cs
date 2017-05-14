using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = 0, n2 = 0, n3 = 0, media = 0;

            Console.WriteLine("Entre com a nota da N1");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a nota da N2");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com  nota N3");
            n3 = double.Parse(Console.ReadLine());

            media = ((n1 + n2 + n3) / 3);

            Console.WriteLine("A media final é: {0}", media);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploArrayParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int total;
            teste Class1 = new teste();

            total = Class1.Soma(1, 2, 3, 4, 5);
            Console.WriteLine(total);
            total = Class1.Soma(10, 20);
            Console.WriteLine(total);

            Console.ReadLine();

        }
    }
}

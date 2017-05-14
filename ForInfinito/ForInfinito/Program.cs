using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForInfinito
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1;
            //exemplo foreach
            foreach (String s in args)
            {
                Console.WriteLine("Par {0}:{1} ", i, s);
                i++;
            }
            Console.ReadLine();
            //exemplo loop infinito enquanto nao ocorre uma condição
            for (;;)
            {
                String s = Console.ReadLine();
                if ((s.ToUpper() == "SAIR"))
                {
                    break;
                }
            }
        }
    }
}

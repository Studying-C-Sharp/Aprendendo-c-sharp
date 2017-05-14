using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutor
{
    class Teste
    {
        int a, b;

        public Teste()
        {
            Console.WriteLine("COnstrutor padrão..."); //é executado apenas uma vez
        }

        static Teste()
        {
            Console.WriteLine("Construtor estatico...");
        }

        public Teste (int a, int b){
            this.a = a;
            this.b = b;
            Console.WriteLine("Construtor customizado...");
            Console.WriteLine("Valor de A: " + a);
            Console.WriteLine("Valor de B " + b);
            Console.WriteLine("a soma dos valores de A e B:" + (a + b));            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
 * se for menor que 18 anos exiba na cor vermelha “Sem permissão”,
 * caso seja maior ou igual a 18 anos exiba na cor verde “Permissão concedida”.
 * *********************************************************************************/

namespace AutentificacaoIdade
{
    class Program
    {
       

        static void Main(string[] args)
        {

            int idades;
            Boolean x;
            Console.WriteLine("Digite sua idade");
            idades = int.Parse(Console.ReadLine());

            x = ValidaIdade(idades);

            if(x == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Entrada negada");
            } else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Entrada permitida");
            }
            Console.ReadLine();

            Boolean ValidaIdade(int idade) {
                if (idade <= 18 && idade >= 0)
                {
                    return true;
                } else
                {
                    if (idade > 18)
                    {
                        return false;
                    }
                }
                return false;

            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Fazer um algoritmo que possa entrar com o saldo de uma aplicação 
 * e imprima o novo saldo, considerando o reajuste de 1%.
 * */
namespace ReajustaValor
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 0,novoValor=0;

            Console.WriteLine("Entre com valor para ser veito o reajuste: ");
            valor = double.Parse(Console.ReadLine());

            novoValor = ((valor*101)/100);

            Console.WriteLine("Nova valor: {0: #.00}", novoValor);
            Console.ReadLine();


        }
    }
}

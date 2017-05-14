using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Desenvolva uma calculadora, onde será necessário 
 * entrar com a operação, primeiro e segundo valor,
 * exiba o resultado na tela.
 * */
namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            String operacao = " ";
            double n1 = 0, n2 = 0, resultado = 0;
            int aux = 0;
            Console.WriteLine("Ex: '*' para multiplicação, '/' para divisão");
            Console.WriteLine("'-' para subtração e '+' para adção");
            Console.WriteLine("-----------------------------------------------");

            while (aux != 1)
            {
                Console.WriteLine("Entre com a Operação a ser realizada: ");

                operacao = Console.ReadLine();
                if(operacao == "*" || operacao == "/" || operacao == "+" || operacao == "-")
                {
                    aux = 1;
                } else
                {
                    aux = 0;
                }
            }
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segunfo valor: ");
            n2 = double.Parse(Console.ReadLine());

            if (operacao == "*")
            {
                resultado = (n1 * n2);
                Console.WriteLine("O resultado da multiplicação é: {0}", resultado);
            }
            else
            {
                if (operacao == "/")
                {
                    resultado = (n1 / n2);
                    Console.WriteLine("O resultado da divisão é: {0}", resultado);
                }
                else
                {
                    if (operacao == "-")
                    {
                        resultado = (n1 - n2);
                        Console.WriteLine("O resultado da subtração é: {0}", resultado);
                    }
                    else
                    {
                        if (operacao == "+")
                        {
                            resultado = (n1 + n2);
                            Console.WriteLine("O resultado da subtração é: {0}", resultado);
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

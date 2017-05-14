using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Desenvolva um algoritmo que solicite a entrada de nome, e-mail, 
 * telefone e RG de um determinado usuário e grave em um arquivo de texto.
 * Exiba as informações na tela a partir do arquivo de texto gerado.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */

namespace GerandoArquivosTXT
{
    class Program
    {
        static void Main(string[] args)
        {
            String caminho = @"C:\Users\ynhic\OneDrive\Documentos\Visual Studio 2017\Projects\Programas-c#\Aprendendo-c-sharp\GerandoArquivosTXT\usuario.txt";
            String acao = "";
            String nome = "Henrique", email = "", rg = "", telefone = "";
            

            Console.WriteLine("##########################");
            Console.WriteLine("##########################");
            Console.WriteLine("G- Gravar ################");
            Console.WriteLine("L- Ler ###################");
            Console.WriteLine("S - Sair #################");
            Console.WriteLine("##########################");
            Console.WriteLine("##########################");

            Console.Write("Digite uma operação: ");
            acao = Console.ReadLine().ToUpper();
            

            while(acao != "S")
            {
                if (acao == "G")
                {
                    Console.WriteLine("Digite Seu nome");
                    nome = Console.ReadLine();

                    Console.WriteLine("Digite seu email");
                    email = Console.ReadLine();

                    Console.WriteLine("Digite seu telefone");
                    telefone = Console.ReadLine();

                    Console.WriteLine("Digite seu RG");
                    rg = Console.ReadLine();

                    StreamWriter sw = new StreamWriter(caminho, true);

                    sw.WriteLine("nome " + nome);
                    sw.WriteLine("Email " + email);
                    sw.WriteLine("telefone " + telefone);
                    sw.WriteLine("rg " + rg);
                    

                    sw.Close();
                    acao = "x";
                    
                } else
                {
                    if (acao == "L")
                    {
                        StreamReader sr = new StreamReader(caminho);

                        while (sr.EndOfStream != true)
                        {
                            Console.WriteLine(sr.ReadLine());
                        }
                        sr.Close();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Pressione uma tecla para continuar...");
                    Console.ReadKey();

                    Console.Clear();
                    Console.WriteLine("##########################");
                    Console.WriteLine("##########################");
                    Console.WriteLine("G- Gravar ################");
                    Console.WriteLine("L- Ler ###################");
                    Console.WriteLine("S - Sair #################");
                    Console.WriteLine("##########################");
                    Console.WriteLine("##########################");
                    Console.Write("Digite uma operação: ");

                    acao = Console.ReadLine().ToUpper();
                    Console.WriteLine();
                }
            }

            

        }
    }
}

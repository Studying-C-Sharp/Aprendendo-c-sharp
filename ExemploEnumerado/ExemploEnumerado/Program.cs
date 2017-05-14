using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEnumerado
{
    class Program
    {
        enum dias_da_semana
        {
            segunda = 1,
            terça = 2,
            quarta = 3,
            quinta = 4,
            sexta = 5,
            sabado = 6,
            domingo = 7,
        }

        static void Main(string[] args)
        {
            dias_da_semana dia;
            dia = dias_da_semana.domingo;
            //formata o nome para aparecer no console
            Console.WriteLine("Dia : {0}", Enum.Format(typeof(dias_da_semana), dias_da_semana.domingo, "G"));
            //pega o nome atraves do numero
            Console.WriteLine("Dia da semana : {0}", Enum.GetName(typeof(dias_da_semana), dia));
            //exibe todos os elemento do Enum
            foreach (String s in Enum.GetNames(typeof(dias_da_semana)))
            {
                Console.WriteLine(s);
            }
            //Mostrada o valor Subjacente do tipo enum
            Console.WriteLine("Valor do subjacente do tipo enum : {0}", Enum.GetUnderlyingType(typeof(dias_da_semana)));

            Console.WriteLine("Sabado é um valor valido: {0}", Enum.IsDefined(typeof(dias_da_semana),"sabado"));

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmploArrayParametro
{
    class teste
    {
        public int Soma(params int[] args)
        {

        
            int total = 0;

            //implementação do metodo
            foreach(int element in args)//soma o todos os valores do arry
            {
                total = total + element;
            }
            return (total);
        }
    }
}

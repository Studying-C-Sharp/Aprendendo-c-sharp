using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArryasExemplo
{
    class ArraysDimensionais
    {
        private int[] arrInt = new int[2] { 1, 2 };
        private int[,] multInt = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        private int[][,] arrDeArr = new int[2][,] { new int[2, 2] { { 1, 2 }, { 3, 4 } }, new int[2, 2] { { 5, 6 }, { 7, 8 } } };

        public void ImprimirArray()
        {
            for (int i = 0; i < arrDeArr.Length; i++)
            {
                Console.WriteLine("Elemento {0}: ", i, arrDeArr[i]);
            }
        }
        //metodo preenche um array bidimensional
        public void PreencherArrayBI()
        {
            for (int i = 0; i < multInt.GetLength(0); i++)
            {
                for (int j = 0; j < multInt.GetLength(1); j++)
                {
                    multInt[i, j] = i * j;
                }
            }
        }
        //mostrando os dado de um array BI
        public void MostrarArrayBi()
        {
            Console.WriteLine("Mostrando array Bidimensional");
            for (int i = 0; i < multInt.GetLength(0); i++)
                for (int j = 0; j < multInt.GetLength(1); j++)
                {
                    Console.WriteLine("{0}\t", multInt[i, j]);
                }
            Console.WriteLine(" ");
        }
        //Mostrando um array de arrays 
        public void ImplimirJaggedArray()
        {
            Console.WriteLine("Imprimindo array de arrays");
            for (int m = 0; m < arrDeArr.Length; m++)
            {
                Console.WriteLine("ArrDeArr[{0}]", m);
                for (int i = 0; i < arrDeArr[m].GetLength(0); i++)
                {
                    for (int j = 0; j < arrDeArr[m].GetLength(1); j++)
                    {
                        Console.WriteLine("{0}\t", arrDeArr[m][i, j]);
                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}

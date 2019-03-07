using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio4_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[5, 5];
            int soma4 = 0, soma2 = 0, soma = 0;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite o valor da posição [" + i + "," + j + "] da matriz:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for(int j = 0; j < 5; j++)
            {
                soma4 += mat[4, j];
            }

            for(int i = 0; i < 5; i++)
            {
                soma2 += mat[i, 2];
            }

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    soma += mat[i, j];
                }
            }

            

            Console.WriteLine("Soma dos elementos da linha 4: " + soma4);
            Console.WriteLine("Soma dos elementos da coluna 2: " + soma2);
            Console.WriteLine("Soma de todos os elementos da matriz: " + soma);

            Console.ReadKey();






        }
    }
}

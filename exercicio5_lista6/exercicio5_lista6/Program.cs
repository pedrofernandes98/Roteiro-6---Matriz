using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 5];
            int[] vet = new int[5];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Digite o valor da posição [" + i + "," + j + "] da matriz:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    vet[j] += mat[i, j];
                }
            }

            Console.WriteLine("Vetor com a soma das colunas da matriz:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(vet[i] + " | ");
            }

            Console.WriteLine("\n\nMatriz:");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i, j] + " | ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[8, 6];
            int soma = 0;
            double media;

            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    Console.WriteLine("Digite o valor da posição [" + i + "," + j + "] da matriz:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            /*for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(mat[i,j] + " | ");
                    
                }
                Console.Write("\n");
            }*/

            for (int i =0; i < 8; i= i+2)
            {
                for(int j = 0; j < 6; j++)
                {
                    soma += mat[i, j];
                }
            }

            media = soma / 24.0;
            Console.WriteLine("Media das Linhas pares: " + media);

            Console.ReadKey();




        }
    }
}

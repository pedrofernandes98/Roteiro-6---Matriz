using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio2_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[4, 4];
            int num;
            int[,] nova_mat = new int[4, 4];

            for(int i = 0; i < 4; i++)
            {
                for(int j=0; j < 4; j++)
                {
                    Console.WriteLine("Digite o valor da posição [" + i + "," + j + "] da matriz:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Digite o número que irá multiplicar todos os elementos da matriz: ");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    nova_mat[i, j] = num * mat[i, j];
                }
            }

            Console.WriteLine("Matriz Resultante:");

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write(nova_mat[i, j] + "|");
                }
                Console.Write("\n");
            }

            Console.ReadKey();










        }
    }
}

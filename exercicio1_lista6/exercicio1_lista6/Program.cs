using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, c, cont=0;
            

            do
            {
                Console.WriteLine("Digite o número de linhas da matriz:");
                l = int.Parse(Console.ReadLine());

                if (l <= 0)
                {
                    Console.WriteLine("Valor Inválido! Digite um valor válido para continuar");
                }
            } while (l <= 0);

            do
            {
                Console.WriteLine("Digite o número de colunas da matriz:");
                c = int.Parse(Console.ReadLine());

                if (c <= 0)
                {
                    Console.WriteLine("Valor Inválido! Digite um valor válido para continuar");
                }
            } while (c <= 0);

            int[,] mat = new int[l, c];

            for(int i = 0; i < l; i++)
            {
                for(int j = 0; j < c; j++)
                {
                    Console.WriteLine("Digite o valor da posição" + "[" + i + "," + j+"]");
                    mat[i, j] = int.Parse(Console.ReadLine());

                    if(mat[i,j] > 15 && mat[i,j] < 25)
                    {
                        ++cont;
                    }

                }
            }

            Console.WriteLine("\nNúmero de elementos na matriz maiores que 15 e menores que 25: " + cont);
            Console.ReadKey();



        }
    }
}

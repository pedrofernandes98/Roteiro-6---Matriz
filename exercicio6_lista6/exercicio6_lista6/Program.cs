using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio6_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            int soma1 = 0, soma2 = 0;
            double media_principal, media_secundaria;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite o valor da posição [" + i + "," + j + "]:");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
            
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(mat[i, j] + " | ");
                }
                Console.Write("\n");
            }

            for(int i = 0; i < 3; i++)
            {
                soma1 += mat[i, i];
                soma2 += mat[i, 2 - i];
            }

            media_principal = soma1 / 3.0;
            media_secundaria = soma2 / 3.0;

            Console.WriteLine("Media da Matriz Principal: " + media_principal);
            Console.WriteLine("Média da Matriz Secundária: " + media_secundaria);





            Console.ReadKey();
        }
    }
}

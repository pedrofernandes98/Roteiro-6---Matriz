using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio8_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[10];
            int[] vet2 = new int[10];
            int[] vet3 = new int[10];
            int[,] mat = new int[10, 3];
            int aux;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor da posição " + i + " do vetor 1:");
                vet1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor da posição " + i + " do vetor 2");
                vet2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o valor da posição " + i + " do vetor 3:");
                vet3[i] = int.Parse(Console.ReadLine());
            }

            /*Imprimir vetores
            
            for(int i = 0; i < 10; i++)
            {
                Console.Write(vet1[i] + " | ");
            }
            Console.Write("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vet2[i] + " | ");
            }
            Console.Write("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vet3[i] + " | ");
            }

            Console.Write("\n");*/
            /*Preenche Matriz Original
            for (int l = 0; l < 10; l++)
            {
                mat[l, 0] = vet1[l];
            }

            for (int l = 0; l < 10; l++)
            {
                mat[l, 1] = vet2[l];
            }

            for (int l = 0; l < 10; l++)
            {
                mat[l, 2] = vet3[l];
            }*/
            /*Imprime Matriz Original
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(mat[i, j] + " | ");
                }
                Console.Write("\n");
            }*/





            //Ordenação dos Vetores


            for (int i = 0; i < 9; i++)
            {
                for(int j = i + 1; j < 10; j++)
                {
                    if(vet1[i] > vet1[j])
                    {
                        aux = vet1[i];
                        vet1[i] = vet1[j];
                        vet1[j] = aux;
                    }
                }   
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (vet3[i] > vet3[j])
                    {
                        aux = vet3[i];
                        vet3[i] = vet3[j];
                        vet3[j] = aux;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (vet2[i] < vet2[j])
                    {
                        aux = vet2[i];
                        vet2[i] = vet2[j];
                        vet2[j] = aux;
                    }
                }
            }


            //Preenchimento da Matriz Ordenada

            for (int l = 0; l < 10; l++)
            {
                mat[l, 0] = vet1[l];
            }

            for(int l = 0; l < 10; l++)
            {
                mat[l, 1] = vet2[l];
            }

            for (int l = 0; l < 10; l++)
            {
                mat[l, 2] = vet3[l];
            }
            //Imprime Matriz Ordenada
            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(mat[i, j] + " | ");
                }
                Console.Write("\n");
            }

            Console.ReadKey();



        }
    }
}

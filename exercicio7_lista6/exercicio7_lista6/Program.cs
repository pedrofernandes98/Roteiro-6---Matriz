using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio7_lista6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n, cont1=0;
            double soma=0,media;
            double m=0;

            do
            {
                Console.WriteLine("Digite o número de semanas emitidas no relatório: ");
                n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("Valor inválido! Digite um valor válido para continuar.");
                }
            } while (n <= 0);

            double[,] prod = new double[n,7];
            double[] menor = new double[n];

            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                        Console.WriteLine("Digite o valor da produção no dia " + (j + 1)  +" da semana " + (i+1));
                        prod[i,j] = double.Parse(Console.ReadLine());
                        soma += prod[i, j];
                }
            }

            media = soma / (n * 7.0);

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if(prod[i,j] > media)
                    {
                        ++cont1;
                    }              
                }
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    if (j == 0)
                    {
                        m = prod[i, j];
                        menor[i] = j;
                        
                    }
                    else
                    {
                        if (prod[i, j] < m)
                        {
                            m = prod[i, j];
                            menor[i] = j;
                        }
                    }
                }
            }
            
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < 7; j++)
                {
                    Console.Write(prod[i, j] + " | ");
                }
                Console.Write("\n");
            }


            Console.WriteLine("RELATÓRIO DE PRODUÇÃO RELATIVO À " + n + " SEMANAS");

            for(int i = 0; i < 60; i++)
            {
                Console.Write("- ");
            }

            Console.WriteLine("\nProdução média = " + media);
            Console.WriteLine("Número de dias com produção acima da média = " + cont1);
            Console.WriteLine("\n\nINDICAÇÃO DOS DIAS DE MÍNIMA PRODUÇÃO: ");
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Semana " + (i + 1) + " .......................................... Dia " + (menor[i]+1));
            }

            Console.ReadKey();
            












        }
    }
}

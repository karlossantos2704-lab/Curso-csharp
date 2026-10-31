using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Vetores.MetodosVetor
{
    internal class MetodosVetor
    {
        public static void Metodosvetor()
        {
            int[] numeros = { 42, 7, 19, 3, 55, 28 };

            //Ordenação
            Array.Sort(numeros);
            Console.WriteLine("Ordenado");
            foreach (int n in numeros)
            {
                Console.WriteLine($"{n}");
            }
            Console.WriteLine();


            //Inverssão
            Array.Reverse(numeros);
            Console.WriteLine("Inverso");
            foreach (int n in numeros)
            {
                Console.WriteLine($"{n}");
            }
            Console.WriteLine();


            //Pesquisa
            Console.Write("Digite um numero para buscar");
            int busca = int.Parse(Console.ReadLine());
            int posicao = int.Parse(Console.ReadLine());

            if (posicao >= 0)
            {
                Console.WriteLine($"Encontrado na posição {posicao}");
            }
            else
            {
                Console.WriteLine("Numero não encontrado no vetor");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Vetores.NotasUsandoVetor
{
    internal class NotasUsandoVetor
    {
        public static void NotasUsandoVetores()
        {
            int quantidade = 5;
            double[] notas = new double[quantidade];
            double soma = 0;

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"Digite a {i + 1} nota");
                notas[i] = double.Parse(Console.ReadLine());
                soma += notas[i];
            }

            double media = soma / quantidade;
            Console.WriteLine($"/nMédia da turma: {media:F1}");
            Console.WriteLine($"/n Alunos acima da média");

            for (int i = 0; i < quantidade; i++)
            {
                if (notas[i] >= media)
                {
                    Console.WriteLine($"Aluno {i + 1}: {notas[i]}");
                }
            }


        }
    }
}

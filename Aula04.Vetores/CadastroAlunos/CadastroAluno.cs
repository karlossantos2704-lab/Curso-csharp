using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Vetores.CadastroAlunos
{
    internal class CadastroAluno
    {
        internal class CadastroAluno
        {
            public static void CadastroDeAluno()
            {
                Console.WriteLine("Quantos Alunos");
                int quantidade = int.Parse(Console.ReadLine());

                string[] nomes = new string[quantidade];
                double[] notas = new double[quantidade];
                double soma = 0;

                for (int i = 0; i < quantidade; i++)
                {
                    Console.WriteLine($"/nNome do Aluno {i + 1}:");
                    nomes[i] = Console.ReadLine();

                    Console.WriteLine($"Nota do(a) {nomes[i]}");
                    notas[i] = double.Parse(Console.ReadLine());
                    soma += notas[i];
                }

                double media = soma / quantidade;

                //Encontra a maior nota
                int indiceMelhor = 0;
                for (int i = 1; i < quantidade; i++)
                {
                    if (notas[i] > notas[indiceMelhor])
                    {
                        indiceMelhor = i;
                    }

                    Console.WriteLine("/n --- Resultado ---");
                    for (int i = 0; i < quantidade; i++)
                    {
                        string situação = notas[i] >= 7 ? "Aprovado" : "Reprovado";
                        Console.WriteLine($"{nomes[i]}: {notas[i]:F1} - {situação}");
                    }

                    Console.WriteLine($"/nMédia da turma: {media:F1}");
                    Console.WriteLine($"Melhor Aluno: {nomes[indiceMelhor]} ({notas[indiceMelhor]})");

                }

            }
        }
    }
}

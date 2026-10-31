internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            bool continuar = true;
            string nomeAluno;
            decimal n1 = 0, n2 = 0, n3 = 0, n4 = 0;
            decimal media = 0;

            while (continuar)
            {
                nomeAluno = CapturarNomeAluno();

                for (int i = 1; i <= 4; i++)
                {
                    Console.WriteLine($"Digite a {i} nota");

                    switch (i)
                    {
                        case 1:
                            n1 = decimal.Parse(Console.ReadLine());
                            break;
                        case 2:
                            n2 = decimal.Parse(Console.ReadLine());
                            break;
                        case 3:
                            n3 = decimal.Parse(Console.ReadLine());
                            break;
                        case 4:
                            n4 = decimal.Parse(Console.ReadLine());
                            break;
                    }
                }

                media = CalcularMedia(n1, n2, n3, n4);

                Console.WriteLine($"A media do aluno {nomeAluno} é {media:F1}");

                Console.WriteLine($"Deseja avaliar outro aluno? 1 = sim, 2 = não");
                continuar = Console.ReadLine() == "1";
            }
        }
        static string CapturarNomeAluno()
        {
            Console.WriteLine($"Digite o nome do Aluno: ");
            string nome;
            nome = Console.ReadLine();
            return nome;
        }
        static decimal CalcularMedia(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal soma = n1 + n2 + n3 + n4;
            decimal resultado = soma / 4;
            return resultado;
        }

    }
}
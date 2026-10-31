internal class Program
{
    private static void Main(string[] args)
    {

    }
    public static void DeclaracaoCriacaoDeVetores()
    {
        int[] numeros = new int[5];

        numeros[0] = 10;
        numeros[1] = 20;
        numeros[2] = 30;
        numeros[3] = 40;
        numeros[4] = 50;

        Console.WriteLine($"Primeiro: {numeros[0]}");
        Console.WriteLine($"Último: {numeros[4]}");
        Console.WriteLine($"Quantidade de Gavetas: {numeros.Length}");


        //Iniciação Direta
        string[] nomes = { "Ana", "Bruno", "Carlos" };
        Console.WriteLine($"Segundo nome {nomes[1]}");
    }

    public static void PercorrendoVetores()
    {
        double[] temperaturas = { 28.5, 31.2, 27.8, 33.0, 29.4 };

        //soma com for
        double soma = 0;
        for (int i = 0; i < temperaturas.Length; i++)
        {
            soma += temperaturas[i];
        }
        Console.WriteLine($"Soma: {soma}");

        //Media
        double media = soma / temperaturas.Length;
        Console.WriteLine($"Media: {media:F1}");

        //Máximo e mínimo com foreach
        double maximo = temperaturas[0];
        double minimo = temperaturas[0];

        foreach (double temp in temperaturas)
        {
            if (temp > maximo) maximo = temp;
            if (temp < minimo) minimo = temp;
        }

        Console.WriteLine($"Máxima:{maximo}");
        Console.WriteLine($"Mínima: {minimo}");
    }
    public static void MetodosVetor()
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
    /// Crie um programa que leia 10 números inteiros digitados pelo 
    /// usuário e os exiba em ordem inversa à que foram digitados.

    public static void OrdemInversa()
    {
        int quantidade = 10;
        int[] numeros = new int[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"Digite o {i + 1} números: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("/n----Números em ordem inversa----");
        for (int i = quantidade - 1; i >= 0; i--)
        {
            Console.WriteLine($"{numeros[i]}");
        }
        Console.WriteLine();
    }

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

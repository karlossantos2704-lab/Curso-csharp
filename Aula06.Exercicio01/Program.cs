using Aula06.Exercicio01;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Carlos Manoel", 30, "Rua Izis dias de Oliveira");
        Pessoa pessoa2 = new Pessoa("Maria Eduarda", 13, "Rua Izis dias de Oliveira");

        pessoa1.Apresentar();
        pessoa2.Apresentar();

        pessoa1.FazerAniversario();
        pessoa2.FazerAniversario();

        pessoa1.Apresentar();
        pessoa2.Apresentar();

    }
}
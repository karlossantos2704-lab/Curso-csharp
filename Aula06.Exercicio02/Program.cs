using Aula06.Exercicio02;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta1 = new ContaBancaria("Carlos Manoel", "1592-11", 1000);

        conta1.Depositar(500);

        conta1.sacar(300);



        conta1.ExibirDados();



    }
}
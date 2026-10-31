using Aula08.HerencaSimples;

internal class Program
{
    private static void Main(string[] args)
    {
        Carro carro = new Carro("WK", "Kombi", 1985, 3);
        carro.ExibirInfo();
        carro.ExibirInfoCompleta();
    }
}

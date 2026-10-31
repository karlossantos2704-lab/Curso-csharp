using Aula10.Exercicio01;
using Aula10.Exercicio1;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos = new Veiculo[3];

        veiculos[0] = new Carro("ABC-3039", 2010, 30000, 4);
        veiculos[1] = new Moto("DED-0293", 2008, 10000, 750);

        foreach (Veiculo ve in veiculos)
        {
            Console.WriteLine(ve.ExibirResumo());
            Console.WriteLine($"IPVA: R$ {ve.CalcularIPVA():F2}");

        }
    }
}

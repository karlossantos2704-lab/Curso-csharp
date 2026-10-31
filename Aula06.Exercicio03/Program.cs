using Aula06.Exerciocio03.Colaborador;
using Aula06.Exerciocio03.Empresa.TI;

internal class Program
{
    private static void Main(string[] args)
    {
        Colaborador colaborador1 = new Colaborador();

        colaborador1.ExibirFicha("Carlos Manoel", "Auxiliar");

        Equipamento equipamento1 = new Equipamento();

        equipamento1.ExibirTermo("Sansung", "3039");

    }
}
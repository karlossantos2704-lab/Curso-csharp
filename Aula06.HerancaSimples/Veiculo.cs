using System;
using System.Collections.Generic;
using System.Text;

namespace Aula08.HerencaSimples
{
    internal class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        public Veiculo(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"{Marca} {Modelo} {Ano}");
        }
    }
    //Class derivada
    class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro(string marca, string modelo, int ano, int portas)
            : base(marca, modelo, ano)
        {
            NumeroPortas = portas;
        }
        public void ExibirInfoCompleta()
        {
            base.ExibirInfo();//chama o metodo da classe base
            Console.WriteLine($"Portas: {NumeroPortas}");
        }
    }
}

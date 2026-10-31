using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10.Exercicio01
{
    abstract class Veiculo
    {
        public string Placa { get; set; }
        public int Ano { get; set; }
        public double ValorVenal { get; set; }

        public Veiculo(string placa, int ano, double valorVenal)
        {
            Placa = placa;
            Ano = ano;
            ValorVenal = valorVenal;
        }
        public abstract double CalcularIPVA();

        public string ExibirResumo()
        {
            return $"{Placa} ({Ano}) - Valor Venal: R$ {ValorVenal}";
        }
    }
    class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }

        public Carro(string placa, int ano, double valorVenal, int portas)
            : base(placa, ano, valorVenal)
        {
            NumeroDePortas = portas;
        }

        public override double CalcularIPVA()
        {
            return ValorVenal * 0.04;
        }
    }

    class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto(string placa, int ano, double valorVenal, int cilindradas)
            : base(placa, ano, valorVenal)
        {
            Cilindradas = cilindradas;
        }

        public override double CalcularIPVA()
        {
            return ValorVenal * 0.02;
        }

    }
}

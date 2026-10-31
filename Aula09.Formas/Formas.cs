using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Polimorfismo
{
    internal class Forma
    {
        public virtual double CalcularArea()
        {
            return 0;
        }
    }
    class Circulo : Forma
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }
    }
    class Retangulo : Forma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(Double largura, Double altura)
        {
            Largura = largura;
            Altura = altura;
        }
        public override Double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}

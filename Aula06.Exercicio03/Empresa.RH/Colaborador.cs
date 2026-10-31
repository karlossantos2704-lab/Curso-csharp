using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06.Exerciocio03.Colaborador
{
    internal class Colaborador
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public void ExibirFicha(string Nome, string Cargo)
        {
            Console.WriteLine($"[RH] Colaborador: {Nome} | Cargo: {Cargo}");
        }
    }
}
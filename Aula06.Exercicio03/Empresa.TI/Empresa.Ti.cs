using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06.Exerciocio03.Empresa.TI
{
    internal class Equipamento
    {
        public string Tag { get; set; }

        public string Modelo { get; set; }

        public void ExibirTermo(string Modelo, string Tag)
        {
            Console.WriteLine($"[TI] Equipamento: {Modelo} | Tag: {Tag}");
        }
    }
}

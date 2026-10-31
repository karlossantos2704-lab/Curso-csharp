using System;
using System.Collections.Generic;
using System.Text;

namespace Aula10.MetodosAbstratas
{
    abstract class Animal
    {
        public string Nome { get; set; }

        public Animal(string nome)
        {
            Nome = nome;
        }
        public abstract string EmitirSom();
    }

    class Cachorro : Animal
    {
        public string Raca { get; set; }

        public Cachorro(string nome, string raca) : base(nome)
        {
            Raca = raca;
        }

        public override string EmitirSom()
        {
            return $"{Nome} diz: Au au!";
        }
    }
    class Gato : Animal
    {
        public bool EhDomentico { get; set; }

        public Gato(string nome, bool ehDomestico) : base(nome)
        {
            EhDomentico = ehDomestico;
        }

        public override string EmitirSom()
        {
            return $"{Nome} Diz: Miau";

        }



    }
}

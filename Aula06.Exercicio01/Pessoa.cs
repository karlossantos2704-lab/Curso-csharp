using System;
using System.Collections.Generic;
using System.Text;

//Crie uma classe `Pessoa` com os seguintes requisitos:
//**Atributos:**
//- `nome` (string)
//- `idade` (int)
//- `endereco` (string)

//**Construtor:**
//-Recebe nome, idade e endereço como parâmetros.

//**Métodos:**
//- `Apresentar()` — exibe no console: "Olá, meu nome é [nome], tenho [idade] anos e moro em [endereco]."
//- `FazerAniversario()` — incrementa a idade em 1 e exibe: "[nome] fez [idade] anos!"

//* *No Main: **
//1.Crie pelo menos 2 objetos `Pessoa` com dados diferentes.
//2. Chame `Apresentar()` em cada um.
//3. Chame `FazerAniversario()` em um deles.
//4. Chame `Apresentar()` novamente para confirmar que a idade mudou

namespace Aula06.Exercicio01
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string endereco;

        public Pessoa(string nome, int idade, string endereco)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome e {nome}, tenho {idade} anos e moro em {endereco}");
        }
        public void FazerAniversario()
        {
            idade++;

            Console.WriteLine($"{nome}, faz {idade} anos!");
        }




    }
}

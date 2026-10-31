using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06.Exercicio02
{
    internal class ContaBancaria
    {
        private string titular;
        private string numero;
        private double _saldo;

        public string Titular { get => titular; }
        public string Numero { get => numero; }
        public double Saldo { get => _saldo; }

        public ContaBancaria(string titular, string numero, double saldoInicial)
        {
            this.titular = titular;
            this.numero = numero;

            if (saldoInicial < 0)
            {
                Console.WriteLine("Saldo inicial não pode ser negativo. Definido como zero");
                this._saldo = saldoInicial;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Erro: O valor do depósito deve ser positivo");
                return;
            }

            _saldo += valor;
            Console.WriteLine($"Deposito de R$ {valor:F2} realizado com sucesso!");
        }

        public void sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro: Valor do saque deve ser positivo");
                return;
            }
            if (valor > 0)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }

            _saldo -= valor;
            Console.WriteLine($"Saque de R4 {valor:F2} realizado com sucesso!");
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: {Saldo:F2}");
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Conta: {Numero}");
            Console.WriteLine($"Saldo: R$ {Saldo:F2}");
        }
    }
}
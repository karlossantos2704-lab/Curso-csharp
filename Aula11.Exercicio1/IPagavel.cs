using System;
using System.Collections.Generic;
using System.Text;

namespace Aula11.Exercicio01
{
    interface IPagavel
    {
        public decimal ProcessarPagamento(decimal valor);
        public string GerarComprovante();
    }

    class Boleto : IPagavel
    {
        public string CodigoDeBarras { get; set; }
        public DateTime DataDeVencimento { get; set; }

        public Boleto(string codigo, DateTime vencimento)
        {
            CodigoDeBarras = codigo;
            DataDeVencimento = vencimento;
        }

        public decimal ProcessarPagamento(decimal valor)
        {
            return valor;
        }

        public string GerarComprovante()
        {
            return $"BOLETO | Código:{CodigoDeBarras} | Vencimento:{DataDeVencimento:dd/MM/yyyy}";
        }

    }
    class CartaoDeCredito : IPagavel
    {
        public string NumeroDoCartao { get; set; }
        public int Parcelas { get; set; }

        public CartaoDeCredito(string numero, int parcelas)
        {
            NumeroDoCartao = numero;
            Parcelas = parcelas;
        }

        public decimal ProcessarPagamento(decimal valor)
        {
            decimal acrescimo = valor * (0.025m * Parcelas);
            return valor + acrescimo;
        }
        public string GerarComprovante()
        {
            string mascarado = $"****_****_****_{NumeroDoCartao.Substring(12)}.";
            return $"CARTÃO | {mascarado} | {Parcelas}x";
        }
    }

    class Pix : IPagavel
    {
        public string ChavePix { get; set; }

        public Pix(string chave)
        {
            ChavePix = chave;
        }

        public decimal ProcessarPagamento(decimal valor)
        {
            return valor * 0.95m;
        }

        public string GerarComprovante()
        {
            return $"PIX | Chave: {ChavePix} | Desconto de 5% aplicado";
        }
    }
}
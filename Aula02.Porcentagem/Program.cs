internal class Program
{
    private static void Main(string[] args)
    {
        // Dado um valor entre 10 e 10.000
        // de 10 -> 100 => 1%
        // de 101 -> 1000 => 3%
        // de 1001 -> 5000 => 5%
        // acima disso => 6%
        // EU QUERO A % PORCENTAGEM do vendedor

        while (true)
        {
            Console.WriteLine("Digite o valor da venda (ou 'sair' para encerrar)");
            string? entrada = Console.ReadLine();

            if (entrada?.Trim().ToLower() == "sair")
                break;

            if (!decimal.TryParse(entrada, out decimal valorVenda) || valorVenda < 0)
            {
                Console.WriteLine("Valor inválido. Digite um valor válido.");
                continue;
            }

            decimal percentual = ObterPercentualComissao(valorVenda);

            if (percentual == 0)
            {
                Console.WriteLine("Valor de venda elegivível para comissão");
                continue;
            }

            decimal comissao = valorVenda * percentual;
            Console.WriteLine($"A porcentagem do vendedor é de {percentual:P0}");
            Console.WriteLine($"O valor da comissão é {comissao:C}");

        }
    }
    static decimal ObterPercentualComissao(decimal valorVenda)
    {
        return valorVenda switch
        {
            < 10 => 0m,
            <= 100 => 0.01m,
            <= 1000 => 0.03m,
            <= 5000 => 0.05m,
            _ => 0.06m

        };
    }

}
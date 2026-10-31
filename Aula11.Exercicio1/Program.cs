using Aula11.Exercicio01;

List<IPagavel> pagamentos = new List<IPagavel>
{
    new Boleto("34191.79001 01043.510047", new DateTime(2026, 11, 30)),
    new CartaoDeCredito("1234567812345678", 3),
    new Pix("karlos@email.com")
};

foreach (IPagavel p in pagamentos)
{
    Console.WriteLine($"Total: {p.ProcessarPagamento(100m):C}");
    Console.WriteLine(p.GerarComprovante());
    Console.WriteLine();
}

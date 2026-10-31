using Aula09.Polimorfismo;
internal class Program
{
    private static void Main(string[] args)
    {
        Forma[] formas = new Forma[3];
        formas[0] = new Circulo(5);
        formas[1] = new Retangulo(4, 6);
        formas[2] = new Circulo(3);
        //Forma formaTesteParaMostrarQueFilhosHErdam = new Circulo(3);
        foreach (Forma forma in formas)
        {
            Console.WriteLine($"Area: {forma.CalcularArea():F2}");
        }


    }
}
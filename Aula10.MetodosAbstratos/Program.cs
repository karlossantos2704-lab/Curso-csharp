using Aula10.MetodosAbstratas;
internal class Program
{
    private static void Main(string[] args)
    {
        Animal[] animais = new Animal[4];
        animais[0] = new Cachorro("REX", "Pitbull");
        animais[1] = new Cachorro("LULU", "CHUAUA");
        animais[2] = new Gato("JERRY", true);
        animais[3] = new Gato("TOTA", false);

        foreach (Animal animal in animais)
        {
            Console.WriteLine(animal.EmitirSom());
        }
        Console.ReadKey();


    }
}
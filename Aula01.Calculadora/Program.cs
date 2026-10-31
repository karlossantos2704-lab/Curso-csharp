internal class Program
{
    private static void Main(string[] args)
    {
        double n1 = 0;
        double n2 = 0;
        double resultado = 0;
        char operador = ' ';

        Console.WriteLine("--CALCULADORA--");

        Console.WriteLine("Digite o primeiro numero");
        if (!double.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine("Entrada Inválida");
            return;
        }

        Console.WriteLine("Digite o segundo numero");
        if (!double.TryParse(Console.ReadLine(), out n2))
        {
            Console.WriteLine("Entrada inválida");
            return;
        }

        Console.WriteLine("Qual operação deseja realizar ? ");
        Console.WriteLine("Para SOMA use '+', DIVISÃO '/', SUBTRAÇÃO '-', MULTIPICAÇÃO '*'.");
        if (!Char.TryParse(Console.ReadLine(), out operador))
        {
            Console.WriteLine("Entrada invalida");
            return;
        }


        //Solução com if
        /*
        if (operador == '+')
        {
            resultado = n1 + n2;
        }
        else if (operador ==  '-')
        {
            resultado = (n1 - n2):
        }
        else if (operador == '*')
        {
            resultado = n1 * n2;
        }
        else if (operador == '/')
        {
            if (n2 == 0)
            {
                Console.WriteLine("ERRO divisão por 0");
            }
            else
            {
                resultado = n1 / n2;
            }
            
        }
        else
        {
            Console.WriteLine("Digite um operador válido ");
        }
        */

        switch (operador)
        {
            case '+':
                resultado = n1 + n2;
                break;
            case '-':
                resultado = n1 - n2;
                break;
            case '*':
                resultado = n1 * n2;
                break;
            case '/':
                if (n2 == 0)
                {
                    Console.WriteLine("ERRO divisão por 0");
                    return;
                }
                else
                {
                    resultado = n1 / n2;
                }
                break;

        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Cálculo {n1} {operador} {n2} ");
        Console.WriteLine($"Resultado {resultado}");
        Console.ResetColor();




    }
}

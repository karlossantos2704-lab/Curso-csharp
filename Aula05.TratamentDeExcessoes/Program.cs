internal class Program
{

    #region Conceitos
    //| Conceito | Analogia |
    //|----------|----------|
    //| **try/catch** | Cinto de segurança.Você espera não precisar, mas ele protege quando algo dá errado. |
    //| **Exceção** | Alarme de incêndio.Avisa que algo saiu do esperado e precisa de atenção. |
    //| **finally** | Trancar a porta ao sair.Você faz isso independente do que aconteceu dentro de casa. |

    //try
    //{
    //    // Código que pode gerar erro
    //}
    //catch (TipoDaExcecao ex)
    //{
    //    // O que fazer quando esse erro acontece
    //}
    //finally
    //{
    //    // Executa sempre, com ou sem erro
    //}

    //**Tipos de exceção comuns:**

    //| Exceção | Quando acontece | Exemplo |
    //|---------|-----------------|---------|
    //| `FormatException` | Conversão de tipo falha | `int.Parse("abc")` |
    //| `DivideByZeroException` | Divisão por zero | `10 / 0` com inteiros |
    //| `IndexOutOfRangeException` | Acesso a índice inválido em vetor | `vetor[10]` quando vetor tem 5 elementos |

    //**Demonstração ao vivo — cada exceção:**
    #endregion

    private static void Main(string[] args)
    {
        // FormatException
        //TestaFormatExcption();

        // DivideByZeroException
        //TestaDividedByZeroExeption();

        // IndexOutOfRangeException
        //TestaIndexOutOfRangeException();

        //CalculadoraRobusta
        try
        {
            CalculadoraRobusta();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void TestaFormatExcption()
    {
        string entrada = "abc";
        int numero = int.Parse(entrada); // lança FormatException
    }

    public static void TestaDividedByZeroExeption()
    {
        int a = 10;
        int b = 0;
        int resultado = a / b; // lança DivideByZeroException

    }

    public static void TestaIndexOutOfRangeException()
    {
        int[] vetor = new int[5];
        vetor[10] = 42; // lança IndexOutOfRangeException
    }

    public static void CalculadoraRobusta()
    {
        //1.O `try` envolve todo o código que pode falhar.
        //2.Cada `catch` trata um tipo específico de exceção.
        //3.A ordem dos `catch` importa: exceções mais específicas primeiro.
        //4.O `finally` executa sempre, independente de erro.
        //5.Teste com entradas válidas, texto e divisão por zero.
        try
        {
            Console.Write("Digite o primeiro número: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal resultado = num1 / num2;
            Console.WriteLine($"Resultado: {resultado}");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Erro: Você deve digitar um número válido!");
            TratarExcessao(e.Message, "Carlos");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Erro: Não é possível dividir por zero!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Erro: O número digitado é muito grande.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Outras excessões não tratadas");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Obrigado por usar a calculadora!");
        }

    }

    public static void TratarExcessao(string msg, string usr)
    {
        Console.WriteLine($"Erro: {msg}. \n Usuario logado: {usr}. \n Quando: {DateTime.Now}");
    }

}

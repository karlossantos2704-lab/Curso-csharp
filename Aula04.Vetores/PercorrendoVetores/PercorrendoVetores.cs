using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Vetores.PercorrendoVetores
{
    internal class PercorrendoVetores
    {
        public static void Percorrendovetores()
        {
            double[] temperaturas = { 28.5, 31.2, 27.8, 33.0, 29.4 };

            //soma com for
            double soma = 0;
            for (int i = 0; i < temperaturas.Length; i++)
            {
                soma += temperaturas[i];
            }
            Console.WriteLine($"Soma: {soma}");

            //Media
            double media = soma / temperaturas.Length;
            Console.WriteLine($"Media: {media:F1}");

            //Máximo e mínimo com foreach
            double maximo = temperaturas[0];
            double minimo = temperaturas[0];

            foreach (double temp in temperaturas)
            {
                if (temp > maximo) maximo = temp;
                if (temp < minimo) minimo = temp;
            }

            Console.WriteLine($"Máxima:{maximo}");
            Console.WriteLine($"Mínima: {minimo}");
        }
    }
}
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um texto:");
        string texto = Console.ReadLine().ToLower();

        Dictionary<char, int> contagemLetras = new Dictionary<char, int>();

        foreach (char letra in texto)
        {
            if (char.IsLetter(letra))
            {
                if (contagemLetras.ContainsKey(letra))
                {
                    contagemLetras[letra]++;
                }
                else
                {
                    contagemLetras[letra] = 1;
                }
            }
        }

        Console.WriteLine("Contagem de letras:");
        foreach (var item in contagemLetras)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}

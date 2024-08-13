using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[5];

        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine($"Digite o nome {i + 1}:");
            nomes[i] = Console.ReadLine();
        }

        // Ordenando os nomes em ordem alfabética
        Array.Sort(nomes);

        Console.WriteLine("Nomes em ordem alfabética:");
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }
}

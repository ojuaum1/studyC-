﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número inteiro:");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}

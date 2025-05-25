using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numerosUnicos = new HashSet<int>();
        int numero;

        Console.WriteLine("Digite números inteiros (digite 0 para parar):");

        while (true)
        {
            Console.Write("Número: ");
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada inválida. Digite um número inteiro.");
                continue;
            }

            if (numero == 0)
            {
                break;
            }

            if (numerosUnicos.Add(numero))
            {
                Console.WriteLine("Número adicionado.");
            }
            else
            {
                Console.WriteLine("Número duplicado (ignorado).");
            }
        }

        Console.WriteLine("\nNúmeros únicos digitados:");
        foreach (int n in numerosUnicos)
        {
            Console.WriteLine(n);
        }
    }
}


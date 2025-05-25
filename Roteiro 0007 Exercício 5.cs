using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Stack<char> pilha = new Stack<char>();

        foreach (char c in palavra)
        {
            pilha.Push(c);
        }

        string palavraInvertida = "";
        while (pilha.Count > 0)
        {
            palavraInvertida += pilha.Pop();
        }

        Console.WriteLine($"Palavra invertida: {palavraInvertida}");
    }
}


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        string opcao;

        Console.WriteLine("=== Fila de Atendimento ===");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar cliente à fila");
            Console.WriteLine("2 - Atender próximo cliente");
            Console.WriteLine("3 - Ver quantos clientes estão na fila");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do cliente: ");
                    string nome = Console.ReadLine();
                    fila.Enqueue(nome);
                    Console.WriteLine($"Cliente '{nome}' adicionado à fila.");
                    break;

                case "2":
                    if (fila.Count > 0)
                    {
                        string proximo = fila.Dequeue();
                        Console.WriteLine($"Atendendo cliente: {proximo}");
                    }
                    else
                    {
                        Console.WriteLine("A fila está vazia. Nenhum cliente para atender.");
                    }
                    break;

                case "3":
                    Console.WriteLine($"Clientes na fila: {fila.Count}");
                    break;

                case "4":
                    Console.WriteLine("Encerrando atendimento. Até logo!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}


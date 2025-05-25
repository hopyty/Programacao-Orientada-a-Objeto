using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaDeCompras = new List<string>();
        string opcao;

        Console.WriteLine("Bem-vindo à Lista de Compras!");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar item");
            Console.WriteLine("2 - Remover item");
            Console.WriteLine("3 - Listar itens");
            Console.WriteLine("4 - Mostrar quantidade de itens");
            Console.WriteLine("5 - Sair");

            Console.Write("Opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o nome do item a adicionar: ");
                    string itemAdicionar = Console.ReadLine();
                    listaDeCompras.Add(itemAdicionar);
                    Console.WriteLine($"'{itemAdicionar}' adicionado com sucesso!");
                    break;

                case "2":
                    Console.Write("Digite o nome do item a remover: ");
                    string itemRemover = Console.ReadLine();
                    if (listaDeCompras.Remove(itemRemover))
                    {
                        Console.WriteLine($"'{itemRemover}' removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemRemover}' não encontrado na lista.");
                    }
                    break;

                case "3":
                    Console.WriteLine("\nItens na lista:");
                    if (listaDeCompras.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia.");
                    }
                    else
                    {
                        foreach (string item in listaDeCompras)
                        {
                            Console.WriteLine("- " + item);
                        }
                    }
                    break;

                case "4":
                    Console.WriteLine($"Quantidade total de itens: {listaDeCompras.Count}");
                    break;

                case "5":
                    Console.WriteLine("Saindo... Até logo!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}


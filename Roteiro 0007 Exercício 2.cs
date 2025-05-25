using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> catalogo = new Dictionary<int, string>();
        string opcao;

        Console.WriteLine("Catálogo de Produtos");

        while (true)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar novo produto");
            Console.WriteLine("2 - Buscar produto pelo código");
            Console.WriteLine("3 - Listar todos os produtos");
            Console.WriteLine("4 - Sair");
            Console.Write("Opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o código do produto (número inteiro): ");
                    if (!int.TryParse(Console.ReadLine(), out int codigo))
                    {
                        Console.WriteLine("Código inválido. Digite um número inteiro.");
                        break;
                    }

                    if (catalogo.ContainsKey(codigo))
                    {
                        Console.WriteLine("Esse código já existe no catálogo.");
                    }
                    else
                    {
                        Console.Write("Digite o nome do produto: ");
                        string nome = Console.ReadLine();
                        catalogo.Add(codigo, nome);
                        Console.WriteLine("Produto adicionado com sucesso!");
                    }
                    break;

                case "2":
                    Console.Write("Digite o código do produto: ");
                    if (!int.TryParse(Console.ReadLine(), out int codBusca))
                    {
                        Console.WriteLine("Código inválido.");
                        break;
                    }

                    if (catalogo.TryGetValue(codBusca, out string nomeProduto))
                    {
                        Console.WriteLine($"Produto encontrado: {nomeProduto}");
                    }
                    else
                    {
                        Console.WriteLine("Código não encontrado no catálogo.");
                    }
                    break;

                case "3":
                    if (catalogo.Count == 0)
                    {
                        Console.WriteLine("Nenhum produto cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Produtos cadastrados:");
                        foreach (var item in catalogo)
                        {
                            Console.WriteLine($"Código: {item.Key} - Produto: {item.Value}");
                        }
                    }
                    break;

                case "4":
                    Console.WriteLine("Saindo... Até logo!");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}


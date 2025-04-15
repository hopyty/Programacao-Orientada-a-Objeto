using System;

public class NomeEmBrancoException : Exception
{
    public NomeEmBrancoException(string mensagem) : base(mensagem) { }
}

public class PrecoInvalidoException : Exception
{
    public PrecoInvalidoException(string mensagem) : base(mensagem) { }
}

class Programa
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new NomeEmBrancoException("O nome do produto não pode estar em branco.");
            }

            Console.Write("Digite o preço do produto: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            if (preco <= 0)
            {
                throw new PrecoInvalidoException("O preço deve ser maior que zero.");
            }

            Console.WriteLine($"\nProduto cadastrado com sucesso!\nNome: {nome}\nPreço: R${preco:F2}");
        }
        catch (NomeEmBrancoException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (PrecoInvalidoException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Formato de preço inválido.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro inesperado: " + ex.Message);
        }
    }
}

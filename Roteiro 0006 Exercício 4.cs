using System;

class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException() : base("Idade mínima para acesso é 18 anos.") { }
}

class Program
{
    static void VerificarIdade(int idade)
    {
        if (idade < 18)
        {
            throw new IdadeInvalidaException();
        }
        else
        {
            Console.WriteLine("Acesso permitido.");
        }
    }

    static void Main()
    {
        Console.Write("Digite a idade: ");

        try
        {
            int idade = int.Parse(Console.ReadLine());
            VerificarIdade(idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Por favor, digite um número inteiro válido.");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase com espaços no início e no fim, e com palavras separadas por vírgulas:");
        string frase = Console.ReadLine();

        string fraseSemEspacos = frase.Trim();
        Console.WriteLine($"\nFrase sem espaços extras: '{fraseSemEspacos}'");

        string[] palavras = fraseSemEspacos.Split(',');
        Console.WriteLine("\nPalavras separadas:");
        foreach (string palavra in palavras)
        {
            Console.WriteLine($"- {palavra.Trim()}"); 
        }
        Console.Write("\nDigite a palavra que deseja substituir: ");
        string palavraAntiga = Console.ReadLine();

        Console.Write("Digite a nova palavra: ");
        string palavraNova = Console.ReadLine();

        string fraseSubstituida = fraseSemEspacos.Replace(palavraAntiga, palavraNova);
        Console.WriteLine($"\nFrase após substituição: '{fraseSubstituida}'");

        Console.Write("\nDigite uma palavra para verificar se a frase começa com ela: ");
        string comeca = Console.ReadLine();
        bool comecaCom = fraseSemEspacos.StartsWith(comeca);
        Console.WriteLine($"A frase começa com '{comeca}'? {comecaCom}");

        Console.Write("\nDigite uma palavra para verificar se a frase termina com ela: ");
        string termina = Console.ReadLine();
        bool terminaCom = fraseSemEspacos.EndsWith(termina);
        Console.WriteLine($"A frase termina com '{termina}'? {terminaCom}");
    }
}

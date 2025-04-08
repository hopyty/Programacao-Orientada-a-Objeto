using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite a data e hora do compromisso (dd/MM/yyyy HH:mm): ");
        string entrada = Console.ReadLine();

        DateTime compromisso = DateTime.ParseExact(entrada, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        DateTime agora = DateTime.Now;

        TimeSpan diferenca = compromisso - agora;
        int diasFaltando = (int)Math.Ceiling(diferenca.TotalDays);
        string diaSemana = compromisso.ToString("dddd", new CultureInfo("pt-BR"));

        string mensagem = string.Format(
            "Olá, {0}!\nSeu compromisso será em {1} dias, na {2}.\nData marcada: {3:dd/MM/yyyy} às {3:HH:mm}",
            nome,
            diasFaltando,
            diaSemana,
            compromisso
        );

        Console.WriteLine();
        Console.WriteLine(mensagem);
    }
}

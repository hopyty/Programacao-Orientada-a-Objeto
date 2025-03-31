using System;
using System.Collections.Generic;

public class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico...");
    }
}

public class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento com Cartão de Crédito...");
        Console.WriteLine("Validando dados do cartão...");
        Console.WriteLine("Realizando cobrança na operadora...");
        Console.WriteLine("Pagamento com cartão processado com sucesso!");
    }
}

public class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento com Boleto Bancário...");
        Console.WriteLine("Gerando código de barras...");
        Console.WriteLine("Registrando boleto no banco...");
        Console.WriteLine("Boleto gerado com sucesso!");
    }
}

public class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento com Pix...");
        Console.WriteLine("Gerando QR Code...");
        Console.WriteLine("Validando chave Pix...");
        Console.WriteLine("Transferência realizada instantaneamente!");
    }
}

class Program
{
    static void Main(string[] args)
    {

        List<Pagamento> pagamentos = new List<Pagamento>();

        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());
        pagamentos.Add(new Pix());
        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());

        Console.WriteLine("Iniciando processamento de pagamentos:");
        Console.WriteLine("---------------------------------------");
        
        foreach (var pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
            Console.WriteLine("---------------------------------------");
        }
    }
}

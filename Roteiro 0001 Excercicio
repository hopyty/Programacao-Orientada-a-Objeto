using System;

public class Pessoa
{
    public string Nome;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e sou {Cargo}.");
    }

    public void InformarSalario()
    {
        double salario = 0;

        switch (Cargo)
        {
            case "Gerente":
                salario = 10000.00;
                break;
            case "Desenvolvedor":
                salario = 5000.00;
                break;
            case "Estagiário":
                salario = 100.00;
                break;
            default:
                salario = 0.00;
                break;
        }

        Console.WriteLine($"O salário do cargo {Cargo} é R$ {salario:0.00}");
    }
}

public class Program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa { Nome = "João", Cargo = "Gerente" };
        Pessoa p2 = new Pessoa { Nome = "Maria", Cargo = "Desenvolvedor" };
        Pessoa p3 = new Pessoa { Nome = "Carlos", Cargo = "Estagiário" };

        p1.Apresentar();
        p1.InformarSalario();
        
        p2.Apresentar();
        p2.InformarSalario();
        
        p3.Apresentar();
        p3.InformarSalario();
    }
}

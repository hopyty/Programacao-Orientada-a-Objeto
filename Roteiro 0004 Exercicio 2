using System;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public int Id { get; set; }
    
    public abstract double CalcularSalario();
}

public class Gerente : Funcionario
{
    public double SalarioBase { get; set; }
    public double Bonus { get; set; }
    
    public override double CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}

public class Programador : Funcionario
{
    public double ValorHora { get; set; }
    public int HorasTrabalhadas { get; set; }
    
    public override double CalcularSalario()
    {
        return ValorHora * HorasTrabalhadas;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new Gerente()
        {
            Nome = "Carlos Silva",
            Id = 1,
            SalarioBase = 10000,
            Bonus = 2000
        };
        
        Programador programador = new Programador()
        {
            Nome = "Ana Souza",
            Id = 2,
            ValorHora = 150,
            HorasTrabalhadas = 160
        };
        
        Console.WriteLine($"Salário do gerente {gerente.Nome}: R${gerente.CalcularSalario():0.00}");
        Console.WriteLine($"Salário do programador {programador.Nome}: R${programador.CalcularSalario():0.00}");
        
        Console.WriteLine("\nUsando polimorfismo com lista de funcionários:");
        
        Funcionario[] funcionarios = new Funcionario[2];
        funcionarios[0] = gerente;
        funcionarios[1] = programador;
        
        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"Salário de {funcionario.Nome}: R${funcionario.CalcularSalario():0.00}");
        }
    }
}

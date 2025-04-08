using System;

public class Elevador
{
    private int _andarAtual;
    private int _totalAndares;

    public Elevador(int totalAndares)
    {
        if (totalAndares <= 0)
        {
            throw new ArgumentException("O elevador deve ter pelo menos 1 andar.");
        }
        _totalAndares = totalAndares;
        _andarAtual = 0;
    }

    public int AndarAtual
    {
        get { return _andarAtual; }
        private set
        {
            if (value < 0 || value > _totalAndares)
            {
                throw new ArgumentOutOfRangeException("Andar inválido.");
            }
            _andarAtual = value;
        }
    }

    public int TotalAndares
    {
        get { return _totalAndares; }
    }

    public void Subir()
    {
        if (_andarAtual < _totalAndares)
        {
            AndarAtual++;
            Console.WriteLine($"Subindo para o andar {AndarAtual}");
        }
        else
        {
            Console.WriteLine("Já está no último andar. Não pode subir mais.");
        }
    }

    public void Descer()
    {
        if (_andarAtual > 0)
        {
            AndarAtual--;
            Console.WriteLine($"Descendo para o andar {AndarAtual}");
        }
        else
        {
            Console.WriteLine("Já está no térreo. Não pode descer mais.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Elevador e = new Elevador(10);
        
        e.Subir();
        e.Subir();
        Console.WriteLine(e.AndarAtual);
        
        e.Descer();
        Console.WriteLine(e.AndarAtual);
        
        e.Descer();
        e.Descer();
        
        Console.WriteLine($"Andar atual: {e.AndarAtual}");
        Console.WriteLine($"Total de andares: {e.TotalAndares}");
    }
}

using System;

class Fantasma
{

    public string Habilidade { get; set; }
    public string Nick { get; set; }
    public string Cor { get; set; }


    public Fantasma(string habilidade, string nick, string cor)
    {
        Habilidade = habilidade;
        Nick = nick;
        Cor = cor;
    }


    public void GerarFantasma()
    {
        Console.WriteLine($"Fantasma criado - Nick: {Nick}, Cor: {Cor}, Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}

class Program
{
    static void Main()
    {
        Fantasma fantasma1 = new Fantasma("Atravesar paredes", "Blinky", "Vermelho");
        
        fantasma1.GerarFantasma();
        
        fantasma1.Mover("direita");
    }
}

using System;

class Animal
{
    public string Nome { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico do animal");
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Au Au!");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Miau!");
    }
}

class Program
{
    static void Main()
    {
        Animal meuAnimal = new Animal();
        meuAnimal.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.EmitirSom();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}

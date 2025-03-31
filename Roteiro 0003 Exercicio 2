using System;

class Item
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Item(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}

class Pedido
{
    public int Numero { get; set; }
    public Item ItemPedido { get; set; }

    public Pedido(int numero, Item item)
    {
        Numero = numero;
        ItemPedido = item;
    }

    public void MostrarPedido()
    {
        Console.WriteLine($"Pedido Nº {Numero}");
        Console.WriteLine($"Item: {ItemPedido.Nome}, Preço: R$ {ItemPedido.Preco:F2}");
    }
}

class Program
{
    static void Main()
    {
        Item item = new Item("Notebook", 3500.00);
        Pedido pedido = new Pedido(1, item);

        pedido.MostrarPedido();
    }
}

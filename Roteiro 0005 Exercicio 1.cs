using System;

class Program
{
    static void Main()
    {
        double[] numeros = new double[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número decimal: ");
            numeros[i] = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("\nResultados:");

        foreach (double numero in numeros)
        {
            Console.WriteLine($"\nNúmero original: {numero}");
            Console.WriteLine($"Arredondamento padrão (Math.Round): {Math.Round(numero)}");
            Console.WriteLine($"Arredondamento para baixo (Math.Floor): {Math.Floor(numero)}");
            Console.WriteLine($"Arredondamento para cima (Math.Ceiling): {Math.Ceiling(numero)}");
            Console.WriteLine($"Truncamento (Math.Truncate): {Math.Truncate(numero)}");
        }
    }
}

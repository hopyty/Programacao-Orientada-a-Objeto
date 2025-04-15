using System;

class Programa
{
    static void Main()
    {
        float temperatura = LerTemperaturaValida();
        Console.WriteLine($"Temperatura válida informada: {temperatura}°C");
    }

    static float LerTemperaturaValida()
    {
        while (true)
        {
            Console.Write("Digite a temperatura em Celsius: ");
            string entrada = Console.ReadLine();

            try
            {
                float temp = float.Parse(entrada);
                return temp;
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida. Por favor, digite um número válido (ex: 25.5).");
            }
        }
    }
}

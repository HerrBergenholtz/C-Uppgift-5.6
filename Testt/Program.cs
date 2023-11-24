using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Skriv in tal som du vill multiplicera som är separerade med \"*\"");
        string[] input = Console.ReadLine().Split("*");
        int[] tal = new int[input.Length];
        
        for (int i = 0; i < input.Length; i++)
        {
            tal[i] = int.Parse(input[i]);
        }

        long produkt = 1;

        for (int i = 0; i < tal.Length; i++)
        {
            produkt *= tal[i];
        }
        Console.WriteLine(produkt);
    }
}
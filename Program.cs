using System;

class Program
{
    static void Main(string[] args)
    {

        {
            Random aleatorio = new Random();
            int valor = aleatorio.Next(1, 10);
            Console.WriteLine($"O Número sorteado é: {valor}");
            Console.ReadKey();
        }
    }
}
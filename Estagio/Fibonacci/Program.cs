using System;

class Program
{
    static bool IsFibonacci(int num)
    {
        if (num < 0) return false;
        int a = 0, b = 1;
        if (num == a || num == b) return true;
        while (b < num)
        {
            int temp = a;
            a = b;
            b = temp + b;

            if (b == num) return true;
        }
        return false;
    }
    static void Main()
    {
        Console.Write("Informe um número: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int num))
        {
            if (IsFibonacci(num))
            {
                Console.WriteLine($"O número {num} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {num} não pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, informe um número inteiro válido.");
        }
    }
}

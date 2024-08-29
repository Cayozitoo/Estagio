using System;
class Program
{
    static void Main()
    {
        Console.Write("Informe uma string: ");
        string input = Console.ReadLine();
        int count = 0;
        foreach (char c in input)
        {
            if (c == 'a' || c == 'A' || c == 'á' || c == 'Á' || c == 'à' || c == 'À' ||
                c == 'â' || c == 'Â' || c == 'ã' || c == 'Ã' || c == 'ä' || c == 'Ä')
            {
                count++;
            }
        }
        Console.WriteLine($"A letra 'a' (e suas variantes acentuadas) aparece {count} vez(es) na string.");
    }
}
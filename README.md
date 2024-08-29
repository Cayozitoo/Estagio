# Projetos C#

Este repositório contém dois programas em C# com funcionalidades distintas:

1. **Contador de Letras 'a'**
2. **Verificador de Números Fibonacci**

## Programas

### 1. Contador de Letras 'a'

#### Descrição

Este programa conta o número de vezes que a letra 'a' (em suas variantes acentuadas) aparece em uma string fornecida pelo usuário.

#### Código

```csharp
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
```

#### Como Usar

1. Compile o código usando um compilador C#.
2. Execute o programa.
3. Informe uma string quando solicitado.
4. O programa retornará a quantidade de vezes que a letra 'a' (e suas variantes acentuadas) aparece na string.

### 2. Verificador de Números Fibonacci

#### Descrição

Este programa verifica se um número fornecido pelo usuário pertence à sequência de Fibonacci.

#### Código

```csharp
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
```

#### Como Usar

1. Compile o código usando um compilador C#.
2. Execute o programa.
3. Informe um número quando solicitado.
4. O programa retornará se o número pertence ou não à sequência de Fibonacci.

## Requisitos

- .NET Framework ou .NET Core/5+/6+ para compilação e execução dos programas.
- Um ambiente de desenvolvimento integrado (IDE) como Visual Studio, Visual Studio Code ou qualquer outro editor de código com suporte para C#.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).

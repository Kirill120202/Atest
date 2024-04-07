using System;

class Program
{
    static void Main(string[] args)
    {
        int M = 1; // Начальное значение
        int N = 10; // Конечное значение
        
        Console.WriteLine($"Натуральные числа от {M} до {N}:");
        PrintNaturalNumbers(M, N);
    }

    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNaturalNumbers(m + 1, n);
        }
    }
}

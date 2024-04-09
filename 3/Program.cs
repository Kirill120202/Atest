using System;

class Program
{
    static void Main(string[] args)
    {
        // Произвольный массив
        int[] array = { 1, 2, 5, 0, 10, 34 };

        // Вызов рекурсивной функции для вывода элементов массива с конца
        PrintArrayReversed(array, array.Length - 1);
    }

    // Рекурсивная функция для вывода элементов массива с конца
    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]); // Вывод текущего элемента
            PrintArrayReversed(array, index - 1); // Рекурсивный вызов для предыдущего элемента
        }
    }
}

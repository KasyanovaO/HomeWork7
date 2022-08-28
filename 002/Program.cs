/*/Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет/*/

class Program
{
    static void FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(0, 10);
            }
        }
    }
    static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите номер строки ");
        int numberrow = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер столбца ");
        int numbercolumn = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[3, 4];
        FillArray(array);
        PrintArray(array);
        if (numberrow > array.GetLength(0) || numbercolumn > array.GetLength(1))
        {
            Console.WriteLine("Такого элемента нет");
        }
        else
        {
            Console.WriteLine($"Значение элемента {array[numberrow - 1, numbercolumn - 1]}");
        }
    }
}


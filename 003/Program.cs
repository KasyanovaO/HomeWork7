/*/Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3./*/

class Program
{
    static void FillArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(1, 10);
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
        int[,] array = new int[3, 4];
        FillArray(array);
        PrintArray(array);
        Console.WriteLine("Среднее арифметическое каждого столбца: ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double sum = 0;
            double average = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = (sum + array[i, j]);
                average = Math.Round((sum / array.GetLength(0)), 1);
            }

            if (j == array.GetLength(1) - 1)
            {
                Console.Write(average + ".");
            }
            else
            {
                Console.Write(average + "; ");
            }
        }
    }
}


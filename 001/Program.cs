/*/Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9/*/


class Program
{
    static void FillArray(double[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = Convert.ToDouble(new Random().NextDouble()*20-10);
            }
        }
    }
    static void PrintArray(double[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = Math.Round(arr[i, j], 1);
                Console.Write(arr[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк m ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбцов n ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"m={m},n={n}");
        double[,] array = new double[m, n];
        FillArray(array);
        PrintArray(array);
    }
}


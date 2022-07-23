// Задача 47. Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] ArrayMatrix(int m, int n, int min, int max)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            double rnd = random.NextDouble() * (max - min) + min;
            array[i, j] = Math.Round(rnd, 2);
        }
    }
    return array;
}

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write("[");
            }
            if (j < array.GetLength(1) - 1)
            {
                Console.Write(array[i, j] + "  ");
            }
            else
            {
                Console.Write(array[i, j] + "]");
            }
        }
        Console.WriteLine();
    }
}

double[,] arr = ArrayMatrix(3, 3, 1, 10);
PrintMatrix(arr);


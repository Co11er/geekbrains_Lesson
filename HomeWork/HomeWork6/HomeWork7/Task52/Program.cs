// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// не получаеться у меня в каждом столбе посчитать среднее арифмитическое

int[,] ArrayMatrix(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(min, max + 1);
        }
    }
    return array;
}

double[,] ArrayСhange(int[,] array)
{
    double[,] arr = new double[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(array[i, j]);
        }
    }
    return arr;
}


double Arithmetic(double[,] arr)
{
    double arithmetic = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arithmetic += arr[j, i];
        }
        arithmetic = Math.Round(arithmetic / arr.GetLength(1), 1);
    }
    return arithmetic;
}

void PrintMatrix(int[,] array)
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

int[,] res = ArrayMatrix(3,3,1,9);
PrintMatrix(res);
double[,] result = ArrayСhange(res);
double arithmetic = Arithmetic(result);
Console.Write(arithmetic);


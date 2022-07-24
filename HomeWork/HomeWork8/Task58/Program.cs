// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] ArrayMatrix1(int row, int col, int min, int max)
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

int[,] ArrayMatrix2(int row, int col, int min, int max)
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

void ProductMatrices(int[,] arrFirst, int[,] arrSecond)
{
    int[,] arrResult = new int[arrFirst.GetLength(0), arrSecond.GetLength(1)];
    if(arrFirst.GetLength(0) == arrSecond.GetLength(1))
    {
    for (int i = 0; i < arrResult.GetLength(0); i++)
    {
        for (int j = 0; j < arrResult.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < arrFirst.GetLength(1); k++)
            {
                sum += arrFirst[i, k] * arrSecond[k, j];
            }
            arrResult[i, j] = sum;
        }
    }
    Console.WriteLine("Произведение матриц");
    PrintMatrix(arrResult);
    }
    else
    {
        Console.Write("матрицы перемножать нельзя");
    }
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
int[,] res1 = ArrayMatrix1(3,5,1,9);
int[,] res2 = ArrayMatrix2(6,3,1,9);
PrintMatrix(res1);
Console.WriteLine();
PrintMatrix(res2);
ProductMatrices(res1,res2);

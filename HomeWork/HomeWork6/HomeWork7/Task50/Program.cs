// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Write("Введите первый элемент: -> ");
int elementFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй элемент: -> ");
int elementSecond = Convert.ToInt32(Console.ReadLine());

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
void Array(int[,] array, int first, int second)
{
    if (first > array.GetLength(0) - 1 || second > array.GetLength(1) - 1)
    {
        Console.Write($"{first}, {second} -> такого числа в массиве нет");
    }
    else
    {
        Console.Write(array[first, second]);
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

int[,] arr = ArrayMatrix(5, 5, 1, 9);
PrintMatrix(arr);
Array(arr, elementFirst, elementSecond);

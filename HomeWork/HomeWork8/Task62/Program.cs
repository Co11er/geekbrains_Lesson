// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// не понимаю как сделать спирать(((((((

void Spiral(int[,] arr)
{   
    int count = 1;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; --j)
        {
            arr[i,j] = count;
            count++;
        }
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
int[,] res = new int[4,4];
Spiral(res);
PrintMatrix(res);
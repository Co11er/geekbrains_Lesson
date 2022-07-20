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

int Araay(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
       sum += array[i, i];
    }
    return sum;
}


void PrintMatrix(int[,] array) // Печать массива
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
                Console.Write(array[i, j] + ",");
            }
            else
            {
                Console.Write(array[i, j] + "]");
            }
        }
        Console.WriteLine();
    }
}

int[,] res = ArrayMatrix(3, 3, 1, 9);
PrintMatrix(res);
int summ = Araay(res);
Console.Write($" Cумма главной диагонали массива = {summ}");
// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Array(int size)
{
    Random random = new Random();
    int[] arr = new int[size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += random.Next(100, 1000);
    }
    return arr;
}

int Positive(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0)
        {
            Console.Write("[");
        }
        if (i < arr.Length - 1)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i] + "]");
        }
    }
}

int[] arrRes = Array(4);
PrintArray(arrRes);
int positive = Positive(arrRes);
Console.Write($" Количество чётных чисел в массиве -> {positive}");

// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] Array(int size, int min, int max)
{
    Random random = new Random();
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] += random.Next(min, max);
    }
    return array;
}

int SumElemNotEvenPos(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}
void PrintAraay(int[] arr)
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

int[] res = Array(4, 0, 30);
PrintAraay(res);
int position = SumElemNotEvenPos(res);
Console.Write($" Сумма элементов, стоящих на нечётных позициях -> {position}");
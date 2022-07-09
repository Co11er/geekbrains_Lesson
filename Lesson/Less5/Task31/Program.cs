
int[] Arr(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

int[] GetSum(int[] arr)
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPos += arr[i];
        }
        else
        {
            sumNeg += arr[i];
        }
    }
    return new[] { sumNeg, sumPos };
}

void PrintArr(int[] arr)
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

int[] resArray = Arr(12);
PrintArr(resArray);
int[] sumNegArray = GetSum(resArray);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел {sumNegArray[1]}");
Console.WriteLine($"Сумма отрицательных чисел {sumNegArray[0]}");





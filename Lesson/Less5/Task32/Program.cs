
int[] Array(int size)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

int Replacement(int[] arr)
{   
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            arr[i] = arr[i] - (arr[i] * 2);
        }
        else
        {
            arr[i] = arr[i] + (arr[i] * 2);
        }
    }
    return result;
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

 int[] rnd = Array(4);
 int replacement = Replacement(rnd);
 PrintArr(rnd);

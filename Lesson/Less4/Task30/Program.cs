
int[] arry = new int[8];

void Arr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i] + " ");
    }
}

Arr(arry);



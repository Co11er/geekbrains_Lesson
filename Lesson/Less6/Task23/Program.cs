int[] Array(int size, int begin, int end)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(begin, end + 1);
    }
    return array;
}

void Reverse(int[] array)   // Реверсия массива, переворот.
//   Array.Reverse(name) -- Встроенный метод реверсии масива
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;
    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
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
int[] arr = Array(5, 1, 9);
PrintAraay(arr);
Reverse(arr);
Console.WriteLine();
PrintAraay(arr);
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int i = 1;

int[] arr = new int[N];
while (i <= arr.Length)
{
    arr[i] = i * i;
    Console.WriteLine(i);
    i++;
}


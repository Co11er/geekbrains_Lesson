// Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] arry = new int[num + 1];
Cubic(arry);
PrintArry(arry);

void Cubic(int[] num)
{
    int counter = 0;
    int length = num.Length;
    while (counter < length)
    {
        num[counter] = Convert.ToInt32(Math.Pow(counter, 3));
        counter++;
    }
}
void PrintArry(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


string[] input = Console.ReadLine().Split().ToArray(); // разделитель строки





Console.Write("Сколько чисел хотите ввести? ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int Quantity(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int result = Quantity(array);
Console.Write($"Чисел больше 0 -> {result}");





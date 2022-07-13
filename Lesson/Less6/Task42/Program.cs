// Система перевода чистала из десятичной в двоичную
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

// int des = 1;
// int result = 0;
// while (num != 0)
// {
//     result = result + num % 2 * des;
//     num = num / 2;
//     des = des * 10;
// }
// Console.WriteLine(result);

void ToBin(int n) // Перевод в двоичную систему через рекурсии
{
    if (n == 0)
    {
        return;
    }
    ToBin(n / 2);
    Console.Write(n % 2);
}
ToBin(num);
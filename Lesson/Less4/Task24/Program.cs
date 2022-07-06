Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()); //создание ввода в консоль

// for (int i = 1; i <= num; i++)
// {
//     sum = sum + i;
//     if (i < num)
//     {
//         Console.Write($"{i} + ");
//     }
//     else
//     {
//         Console.Write($"{i} = ");
//     }
// }
// Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");

int Sum(int numb)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
} 
int res = Sum(num);   
Console.WriteLine($"Сумма чисел от 1 до {num} = {res}");

// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Задайте первое число -> ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте второе число -> ");
int n = int.Parse(Console.ReadLine());


void SumNumber (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    SumNumber(m, n, sum);
}

SumNumber(m, n, 0);
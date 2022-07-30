// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
Console.Write("Задайте число ->");
int num = int.Parse(Console.ReadLine());
int index = 1;


void NaturalNumber(int num, int index)
{
    if (index > num) return;
    NaturalNumber(num, index + 1);
    Console.Write(index + ", ");
}
NaturalNumber(num, index);


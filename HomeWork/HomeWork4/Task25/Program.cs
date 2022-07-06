// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите первое число: -> ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: -> ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Degree(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}
int answer = Degree(numberA, numberB);
Console.Write($"Число {numberA} в степени {numberB} -> {answer}");
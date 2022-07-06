// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.Write("Введите число: -> ");
int number = Convert.ToInt32(Console.ReadLine());

void SumNumber(int numb)
{
    int adv = 0;
    for (int i = 0; i <= numb; i++)
    {
        adv = adv + numb % 10;
        numb = numb / 10;

    }
    Console.Write($"Сумма чисел цифры {number} -> {adv}");
}
SumNumber(number);
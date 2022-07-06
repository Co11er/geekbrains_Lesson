
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());


int Quantity(int digit)
{
    for (int i = digit; i <= 0; i++)
    {
        digit = i / 10;
    }
    return digit;
}
int res = Quantity(num);
Console.WriteLine(num);
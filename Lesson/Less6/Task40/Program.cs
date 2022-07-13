
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

void Triangle(int a, int b, int c)
{
    if (a > (b + c) || b > (a + c) || c > (a + b))
    {
        Console.WriteLine("Треугольник не может существовать");
    }
    else
    {
        Console.WriteLine("Треугольник получиться");
    }
}

Triangle(a,b,c);
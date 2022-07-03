Console.WriteLine("Введите кординаты точки (Х и Y)");
Console.Write("Введите кординату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0)
    {
        return "Первая четверть";
    }
    if (xc < 0 && yc > 0)
    {
        return "Вторая четверть";
    }
    if (xc < 0 && yc < 0)
    {
        return "Третья четверть";
    }
    if (xc > 0 && yc < 0)
    {
        return "Четвертая четверть";
    }
    return "Введены некорректные координаты";
}
string result = Quarter(x, y);
Console.WriteLine(result);

// if (x > 0 && y > 0)
// {
//     Console.WriteLine("Первая четверть");
// }
// else if (x < 0 && y > 0)
// {
//     Console.WriteLine("Вторая четверть");
// }
// else if (x < 0 && y < 0)
// {
//     Console.WriteLine("Третья четверть");
// }
// else if (x > 0 && y < 0)
// {
//     Console.WriteLine("Четвертая четверть");
// }
// else
// {
//     Console.WriteLine("Введены некорректные координаты");
// }

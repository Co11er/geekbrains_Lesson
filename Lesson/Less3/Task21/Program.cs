Console.WriteLine("Введите кординаты точки A");
Console.Write("Введите кординату X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Y: ");
int ya = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите кординаты точки B");
Console.Write("Введите кординату X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int x2, int y2)
{
    int A = 0;
    int B = 0;
    double result = 0.0;

    A = (x1 - x2) * (x1 - x2);
    B = (y1 - y2) * (y1 - y2);
    result = (A + B) * (A + B);
    return result;
}
double result = Distance(xa, ya, xb, yb);
Console.WriteLine(result);

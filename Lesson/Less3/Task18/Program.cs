Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());

string Quater(int xy)
{
    if (xy == 1)
    {
        return "координаты x > 0 и y > 0";
    }
    if (xy == 2)
    {
        return "Коордтнаты x < 0 и b y > 0";
    }
    if (xy == 3)
    {
        return "Коордтнаты x < 0 и b y < 0";
    }
    if (xy == 4)
    {
        return "Коордтнаты x > 0 и b y < 0";
    }
    return "Такой четверти нет";
}
string result = Quater(quater);
Console.WriteLine(result);
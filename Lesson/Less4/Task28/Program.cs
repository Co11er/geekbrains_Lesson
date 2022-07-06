Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int Composition(int numb)
{
    int сomposition = 1;
    for (int i = 1; i <= num; i++)
    {
        сomposition = сomposition * i;
    }
    return сomposition;
} 
int res = Composition(num);   
Console.WriteLine($"Произведение чисел от 1 до {num} = {res}");
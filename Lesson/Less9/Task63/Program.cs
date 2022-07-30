
Console.Clear();
Console.Write("Задайте число");
int num =int.Parse(Console.ReadLine());


void NaturalNumber(int num)
{
   if(num == 0) return;
   NaturalNumber(num - 1);
   Console.Write($"{num} ");
}

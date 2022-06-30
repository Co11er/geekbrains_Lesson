
// Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

int a = 6, b = 10, max = 0;
if(a > b)
{
    max = a;
}else{
    max = b;
}
Console.WriteLine(max);


// Задача 4: Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

int num = 11, num1 = 8, num2 = 10, max1 = num;

if(max1 < num1) {
    max1 = num1;
}
if(max1 < num2) {
    max1 = num2;
}
Console.WriteLine(max1);

// Задача 6: Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0)
{
    Console.WriteLine("Число четное");
}else{
    Console.WriteLine("Число не четное");
}

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++) {
    if(i % 2 == 0){
        Console.WriteLine(" " + i);
    }
}

// Дополнительная задача.
// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.

Console.WriteLine("Введите трёхзначное число");
int number1 = Convert.ToInt32(Console.ReadLine());
int remains = number1 % 10;
Console.Write(remains);
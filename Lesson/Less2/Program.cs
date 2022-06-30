
int rndNum = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {rndNum}");

// int firstDigit = rndNum / 10;
// int secontDigit = rndNum % 10;
// int maxDigit = firstDigit > secontDigit ? firstDigit : secontDigit;
// if(firstDigit > secontDigit)
// {
//    maxDigit = firstDigit;
// }
// else
// {
//    maxDigit = secontDigit;
// }


int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secontDigit = num % 10;
    if (firstDigit == secontDigit) return 0;
    return firstDigit > secontDigit ? firstDigit : secontDigit;
}
int maxDigit = MaxDigit(rndNum);
String result = maxDigit > 0 ? maxDigit.ToString() : "Цыфры равны";
Console.WriteLine($"Наибольшая цыфра числа {rndNum} => {result}");
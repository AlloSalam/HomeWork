using System;

int num = new Random().Next(1, 100000);
int sum = 0;
Console.Write($"Сумма цифр числа {num} равна ");

while (num > 0)
{
    int digit = num % 10;
    sum = sum + digit;
    num = num / 10;
}

Console.WriteLine(sum);

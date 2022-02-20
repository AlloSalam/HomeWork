using System;

Console.WriteLine("Впишите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Впишите степень");
int exponent = Convert.ToInt32(Console.ReadLine());
int count = 1;
int result = num;

while (count < exponent)
{
    result = result * num;
    count++;
}

Console.WriteLine($"{num} в {exponent} степени = {result}");

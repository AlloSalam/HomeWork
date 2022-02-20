using System;

int secnum = new Random().Next(100, 1000);
Console.WriteLine($"Выпало рандомное число {secnum}");
Console.WriteLine($"Вторая цифра числа - {secnum / 10 % 10}");
 
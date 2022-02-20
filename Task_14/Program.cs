using System;

int Num = new Random().Next(1, 1500000);
Console.WriteLine($"Выпало рандомное число {Num}");

if (Num / 100 > 0)
    {
        int newNum = int.Parse(Convert.ToString(Num)[2].ToString());
        Console.WriteLine($"{newNum} является третьей цифрой числа");
    }
else
    {
        Console.WriteLine("У числа нет третьей цифры");
    }
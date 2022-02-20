using System;

int Num = new Random().Next(100, 1000);
int NewNum = 0;
NewNum = Num / 100 * 10 + Num % 10;

Console.WriteLine($"После удаления второй цифры из числа {Num}, получилось новое число {NewNum}");

using System;

Console.Write("Введите кол-во чисел: ");    
int volume = Convert.ToInt32(Console.ReadLine());   //Здесь выбираем из скольки чисел нужно найти числа больше 0
int count = 0;

while (volume > 0)
{
    Console.Write("Введите число:   ");
    int number = Convert.ToInt32(Console.ReadLine());      //Здесь вписываем числа
    if (number > 0) count++;
    volume--;
}
Console.WriteLine($"Количество чисел больше 0: {count}");
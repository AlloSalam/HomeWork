using System;

int Day = new Random().Next(1, 8);
string[] Days = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string Result = "";

if (Day > 5) 
    {
        Result = ", выходной день";
    }
else 
    {
        Result = ", рабочий день";
    }

Console.WriteLine($"{Day}-й день недели - это {Days[Day - 1]}{Result}");

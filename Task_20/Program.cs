using System;

int chetNum = new Random().Next(1, 5);
string diap = "";

if (chetNum == 1) diap = "x > 0, y > 0";
else if (chetNum == 2) diap = "x < 0, y > ";
else if (chetNum == 3) diap = "x < 0, y < 0";
else diap = "x > 0, y < 0";

System.Console.WriteLine($"Для {chetNum}-й четверти координаты точки должны быть заданы в диапазоне ( {diap} )");
System.Console.WriteLine();
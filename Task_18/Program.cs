﻿using System;

int a = new Random().Next(1, 10);
int b = new Random().Next(1, 10);
int x = a;
int y = b;

bool XY = x != a || y == b;
bool notXY = XY != true;
bool notXnotY = x != a | y != b;

System.Console.WriteLine(notXnotY);
System.Console.WriteLine(notXY);

if (notXY == notXnotY) System.Console.WriteLine("Утвеждение истинно");
else System.Console.WriteLine("Утверждение ложно");
System.Console.WriteLine();
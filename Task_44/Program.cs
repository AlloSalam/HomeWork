using System;

int Crossing(int k1, int k2, int b1, int b2)
{
    int x, y;
    x = (b2 - b1)/(k1-k2);
    y = k1*x + b1;
    Console.Write($"\tЭти 2 прямые пересекаются в точке {x}, "); 
    return y;
}
Console.WriteLine(Crossing(1,2,3,4));
﻿int xa = 60, ya = 0;
int xb = 0, yb = 40;
int xc = 120, yc = 40;

Console.Clear();

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0, i = 0;

while (count <= 10000)
{
    i = new Random().Next(0, 3);
    if (i == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    else if (i == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    else
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");

    count++;
}
﻿Console.WriteLine("enter a number");
int x = int.Parse(Console.ReadLine());

for (int i=1;i <= x; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

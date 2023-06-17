﻿/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Quart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    else return -1;
}

int x = InputNum("Ввведите координату х: ");
int y = InputNum("Ввведите координату у: ");

int res = Quart(x, y);
if (res==-1)
Console.WriteLine("Точка находится на оси..");
else
Console.WriteLine($"Четверть {res}");



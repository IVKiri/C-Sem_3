﻿// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координату Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) {
    Console.WriteLine("Это первая четверть.");
}

else if (x < 0 && y > 0) {
    Console.WriteLine("Это вторая четверть.");
}

else if (x < 0 && y < 0) {
    Console.WriteLine("Это третья четверть.");
}

else if (x > 0 && y < 0) {
    Console.WriteLine("Это четвертая четверть.");
}
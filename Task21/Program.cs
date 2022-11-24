// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.
// Math.Sqrt()
// Math.Pow(a, 2)
// d = √ [(x 2 -x 1) 2 + (y 2 -y 1) 2], Где (x 1, y 1) и (x 2, y 2) две точки на плоскости xy.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координаты х1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координаты y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + (Math.Pow((y2 - y1), 2)));
Console.WriteLine(distance);

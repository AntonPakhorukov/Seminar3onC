/*
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/
Console.Clear();

Console.Write("Введите первый координат точки x1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите первый координат точки y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите первый координат точки x2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите первый координат точки y2: ");
double y2 = double.Parse(Console.ReadLine());

double s = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1))); // Math.Pow((x2-x1), 2) = ((x2 - x1) * (x2 - x1))
//double result = Math.Sqrt(s);
Console.WriteLine(s);
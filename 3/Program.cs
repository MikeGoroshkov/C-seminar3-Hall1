//Задача 21: Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21 
Console.Write("Введите X первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите X второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
int d = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1);
double c = Math.Sqrt(d);
Console.WriteLine(c);
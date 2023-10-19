/*
Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход 
координаты двух точек pointA и pointB в виде массива целых чисел, и возвращает 
расстояние между ними в 3D пространстве.
*/


System.Console.WriteLine("Введите X 1ой точки: ");
int X1 = new Random().Next(-10, 10);
System.Console.WriteLine(X1);

System.Console.WriteLine("Введите Y 1ой точки: ");
int Y1 = new Random().Next(-10, 10);
System.Console.WriteLine(Y1);

System.Console.WriteLine("Введите Z 1ой точки: ");
int Z1 = new Random().Next(-10, 10);
System.Console.WriteLine(Z1);

System.Console.WriteLine("Введите X 2ой точки: ");
int X2 = new Random().Next(-10, 10);
System.Console.WriteLine(X2);

System.Console.WriteLine("Введите Y 2ой точки");
int Y2 = new Random().Next(-10, 10);
System.Console.WriteLine(Y2);

System.Console.WriteLine("Введите Z 1ой точки: ");
int Z2 = new Random().Next(-10, 10);
System.Console.WriteLine(Z2);

double sqrX = Math.Pow(X2 - X1, 2);
double sqrY = Math.Pow(Y2 - Y1, 2);
double sqrZ = Math.Pow(Z2 - Z1, 2);

double resalt = Math.Sqrt(sqrX + sqrY + sqrX);

System.Console.WriteLine($"Ответ: {Math.Round(resalt, 3)}");
//d = sqrt (x2 — x1)^2 + (y2 — y1)^2 + (z2 — z1)^2)
/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/
System.Console.WriteLine("Введите X 1ой точки: ");
int X1 = new Random().Next(-10, 10);
System.Console.WriteLine(X1);

System.Console.WriteLine("Введите Y 1ой точки: ");
int Y1 = new Random().Next(-10, 10);
System.Console.WriteLine(Y1);

System.Console.WriteLine("Введите X 2ой точки: ");
int X2 = new Random().Next(-10, 10);
System.Console.WriteLine(X2);

System.Console.WriteLine("Введите Y 2ой точки");
int Y2 = new Random().Next(-10, 10);
System.Console.WriteLine(Y2);

double resalt;
double AC;
double BC;

AC = X2 - X1;
BC = Y2 - Y1;

resalt = Math.Sqrt(AC * AC + BC * BC);

System.Console.WriteLine($"Ответ: {Math.Round(resalt, 3)}");

/*
Console.Clear();
System.Console.Write("Задай координату точки A x:");
int userAX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки A y:");
int userAY = int.Parse(Console.ReadLine());

System.Console.Write("Задай координату точки B x:");
int userBX = int.Parse(Console.ReadLine());
System.Console.Write("Задай координату точки B y:");
int userBY = int.Parse(Console.ReadLine());

//int sqrX = (userBX - userAX) * (userBX - userAX);
double sqrX = Math.Pow(userBX - userAX, 2); //Math.Pow(а, 2) функция возводит в степень (переменная, в какую степень надо возвести)
double sqrY = Math.Pow(userBY - userAY, 2);
double sqrt = Math.Sqrt(sqrX + sqrY); // Math.Sqrt(sqrX + sqrY) выводит квадратный корень из переменной в скобочках
System.Console.WriteLine(Math.Round(sqrt, 2)); // Math.Round(sqrt, 2) округляет десятичное число (переменная, сколько знаков после запятой оставить)
*/
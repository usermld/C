/*
17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.
x=34; y=-30 -> 4 
x=2; y=4-> 1
x=-34; y=-30 -> 3
*/ 

Console.Clear();
System.Console.Write("Введите координату X: ");
int userX = int.Parse(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int userY = int.Parse(Console.ReadLine());

if (userX > 0 && userY > 0) {
System.Console.WriteLine("Точка находится в 1ой четверти");
}
if (userX < 0 && userY > 0) {
System.Console.WriteLine("Точка находится в 2ой четверти");
}
if (userX < 0 && userY < 0) {
System.Console.WriteLine("Точка находится в 3ей четверти");
}
if (userX > 0 && userY < 0) {
System.Console.WriteLine("Точка находится в 4ой четверти");
}

if (userX == 0 || userY == 0) {
    System.Console.WriteLine("Точка находится на оси координат");
}
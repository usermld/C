/*
18. Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/ 
Console.Clear();

System.Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
if (num == 1) {
    System.Console.WriteLine("X > 0, Y > 0");
}
if (num == 2) {
    System.Console.WriteLine("X < 0, Y > 0");
}
if (num == 3) {
    System.Console.WriteLine("X < 0, Y < 0");
}
if (num == 4) {
    System.Console.WriteLine("X > 0, Y < 0");
}
if (num > 4 || num < 1) {
    System.Console.WriteLine("Нет такой четверти");
}

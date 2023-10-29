/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


double k1 = 5;
double b1 = 2;

double k2 = 9;
double b2 = 4;

System.Console.WriteLine($"{k1}, {b1}, {k2}, {b2}");


double LevelsX (double k1, double b1, double k2, double b2)
{
    double x = b2 - b1 / k1 - k2;

    return x;
}

double LevelsY (double b1, double k2, double x)
{
    double y = k2 * x + b1;

    return y;
}


double valueX = LevelsX(k1, b1, k2, b2);
double valueY = LevelsY(b1, k2, valueX);
System.Console.Write(Math.Round (valueX, 2));
System.Console.Write("; ");
System.Console.Write(Math.Round (valueY, 2));
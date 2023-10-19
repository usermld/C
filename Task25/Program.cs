/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double Sqr (int a, int b)
{
    double sum = Math.Pow(a, b);
    return sum;
}

System.Console.WriteLine("Введите Введите число которое будет возводиться в степень: ");
int num1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число на которое будет возводится в степень: ");
int num2 = int.Parse(Console.ReadLine());

double resalt = Sqr(num1, num2);
System.Console.WriteLine(resalt);
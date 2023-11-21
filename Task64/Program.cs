/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/ 


Console.Clear();

void DigitDiaps (int n, int start = 1)
{
    if (start == n + 1)
    {
        return;
    }
    else
    {
        System.Console.Write(n + " ");
        DigitDiaps(n - 1, start);
    }
}


int number = new Random().Next(1, 99);
System.Console.WriteLine(number);
DigitDiaps(number);
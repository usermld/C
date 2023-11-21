/*
65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
*/ 

Console.Clear();

void DigitDiaps (int start, int n)
{
    if (start == n + 1)
    {
        return;
    }
    else
    {
        System.Console.Write(start + " ");
        DigitDiaps(start + 1, n);
    }
}

DigitDiaps(-10, 10);
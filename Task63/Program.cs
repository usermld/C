/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
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
        System.Console.Write(start + " ");
        DigitDiaps(n, start + 1);
    }
}

DigitDiaps(5);
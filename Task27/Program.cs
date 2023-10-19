/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int Number(int num)
{
    int sum = 0;
    for (int i = 0; i < num; i++)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

System.Console.WriteLine("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

int resalt = Number(num1);
System.Console.WriteLine($"Сумма цифр в этом числе равна {resalt}.");
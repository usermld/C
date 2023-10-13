/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int number = new Random().Next(-10, 10);
System.Console.WriteLine(number);

if (number > 1 && number < 6)
{
    System.Console.WriteLine("нет");
}
else if (number > 5 && number < 8)
{
    System.Console.WriteLine("да");
}
else if (number >= 8)
{
    System.Console.WriteLine("нет такого дня");
}
else if (number <= 0)
{
    System.Console.WriteLine("нет такого дня");
}

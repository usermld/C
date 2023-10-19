/*
24. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int resalt = Number(number);
System.Console.WriteLine($"сумма чисел от 1 до {number} равна {resalt}");

int Number(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

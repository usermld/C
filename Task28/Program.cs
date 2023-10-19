/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

int Number(int a)
{
    int sum = 1;
   for (int i = 1; i <= a; i++)
   {
    sum = sum * i;
   }
    return sum;
}

System.Console.WriteLine("Введи ");
int num = int.Parse(Console.ReadLine());

int resalt = Number(num);

System.Console.WriteLine(resalt);
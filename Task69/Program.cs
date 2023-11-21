/*
69. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

Console.Clear();

int Step(int num, int square)
{
    if (square == 1)
    {
        return num;
    }

    else
    {
        return num * Step(num, square - 1);
    }
}

int u_num = Step(3, 3);
System.Console.WriteLine(u_num);
/*
67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
*/ 

Console.Clear();

int Sum (int num)
{
    if (num == 0)
    {
        return 0;
    }
    else 
    {
        return num % 10 + Sum(num / 10);
    }
}


int num = new Random().Next(0, 9999999);
System.Console.WriteLine(num);
int u_num = Sum(num);
System.Console.WriteLine(u_num);
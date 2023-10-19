/*
26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/ 
System.Console.WriteLine("Введи");
int num = int.Parse(Console.ReadLine());
int resalt = Number(num);
System.Console.WriteLine($"{resalt}");

int Number(int num) {
    int sum = 0;
    for (int i = num; i > 0; i/=10)
    {
        sum+=1;
    }
    return sum;
}
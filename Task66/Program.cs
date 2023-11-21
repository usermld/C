/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();

int SumNatureElements (int num_1, int num_2)
{
    int result = num_1;
    for (int i = num_1; i < num_2; i++)
    {
        num_1 += 1;
        result += num_1;
        
    }
    return result;
}

int user_numbers = SumNatureElements(1, 15);
System.Console.WriteLine(user_numbers);
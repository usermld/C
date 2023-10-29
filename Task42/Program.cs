/*
напишите программу которая будет проеоброзовывать десятичное число в двоичное 
*/

Console.Clear();

int Transform (int num)
{
    int result = 0;
    int temp = 1;
    while (num > 0)
    {
        result += num % 2 * temp;
        num /= 2;
        temp *= 10;
    }
    return result;
}

int value = int.Parse(Console.ReadLine());;
System.Console.WriteLine(Transform(value));
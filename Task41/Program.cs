/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int[] MakeArr(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + ", ");
    }
    System.Console.WriteLine("]");
}

void Comparison (int[] arr)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += 1;
    }
    System.Console.WriteLine(sum);
}

int size = new Random().Next(0, 13);
int[] userarr = MakeArr (size);
PrintArray(userarr);
System.Console.WriteLine();
Comparison(userarr);

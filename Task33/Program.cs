/*
33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] MakeArr(int size) 
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
      array[i] = new Random().Next(-9, 10);  
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }
}

void Search(int[] arr, int usernumber)
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == usernumber) s = arr[i];
        else s = s;
    }
    if (s == 0) System.Console.WriteLine("Вашего числа нет в масиве");
    else System.Console.WriteLine($"Ваше число {usernumber} - есть в масиве");
}

System.Console.WriteLine("Введите размер массива");
int n1 = int.Parse(Console.ReadLine());

int[] userArray = MakeArr(n1);

System.Console.WriteLine("Введите число которое хотели бы видеть в масиве");
int un = int.Parse(Console.ReadLine());
PrintArray(userArray);
System.Console.WriteLine();
Search(userArray, un);
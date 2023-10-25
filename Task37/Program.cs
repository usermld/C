/*
37. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

int[] MakeArr(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int[] Math(int[] arr)
{
    int[] newarr = new int[arr.Length / 2];
    int t = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        t = arr[i] * arr[arr.Length - 1];
        newarr[i] = t;
    }
    return newarr;
}

int[] userArray = MakeArr(8);
PrintArray(userArray);
System.Console.WriteLine();
int[] userArray1 = Math(userArray);
System.Console.WriteLine(userArray1);
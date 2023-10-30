/*
45. Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования. 
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
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine("]");
}

int[] CopyArr (int[] arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}

int size = new Random().Next(0, 10);
int[] userArr = MakeArr(size);
PrintArray(userArr);
int[] copyUserArr = CopyArr(userArr);
System.Console.WriteLine();
PrintArray(copyUserArr);

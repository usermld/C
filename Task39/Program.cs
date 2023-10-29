/*
напишите прогу которая перевернёт одномерный массив 
последний элемент - первый
первый - последний
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

void ReversArr (int[] arr)
{

    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

void PrintArray1(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine("]");
}

int[] uarr = MakeArr(15);
PrintArray(uarr);
System.Console.WriteLine();
ReversArr(uarr);
PrintArray1(uarr);
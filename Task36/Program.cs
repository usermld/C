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

void NegNumS(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = arr[i] + sum;
    }
    System.Console.WriteLine(sum);
}

int[] uarr = MakeArr(5);
PrintArray(uarr);
System.Console.WriteLine();
NegNumS(uarr);
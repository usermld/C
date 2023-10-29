int[] MakeArr(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        //array[i] = new Random().Next(0, 10);
        array[i] = Convert.ToInt32(Console.ReadLine());
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

void CountPos (int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) count++;
    }
    System.Console.WriteLine(count);
}

int[] array = MakeArr(10);
PrintArray(array);
System.Console.WriteLine();
CountPos(array);
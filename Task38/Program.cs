Console.Clear();

double[] GetDoubleRend (int size)
{
    double[] array = new double[size]; 

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10) + new Random().NextDouble();
    }
    return array;
}

void PrintDoubleArray (double[] arr)
{
    System.Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(Math.Round(arr[i], 2));
        if (i < arr.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("]");
}

void MinMax (double[] arr)
{
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    System.Console.WriteLine($"разница между {Math.Round(max, 2)} и {Math.Round(min, 2)} = {Math.Round(max - min, 2)}");
}

double[] arrayDouble = GetDoubleRend(5);
PrintDoubleArray (arrayDouble);
System.Console.WriteLine();
System.Console.WriteLine();
MinMax(arrayDouble);
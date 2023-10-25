/*
32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

void Revers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}
void PrintArray1(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]+ " ");
    }
}

int[] userArray = MakeArr(4);
PrintArray(userArray);
System.Console.WriteLine();
Revers(userArray);
PrintArray1(userArray);
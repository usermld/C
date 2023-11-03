/*
52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] Get2DArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

int[] Ariphmetick(int[,] arr)
{
    int[] sumArr = new int[arr.Length];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            while (j < arr.GetLength(1) - 1)
            {
            sum += arr[i, j];
            sum /= arr.GetLength(1);
            sumArr[i] = sum;
            return sumArr;
            }
        }
    }
    return sumArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + "\t");
    }
        System.Console.WriteLine();
}


int[,] userrArr = Get2DArray(2, 2);
Print2DArray(userrArr);
Ariphmetick(userrArr);
int[] AriphmetickArr = Ariphmetick(userrArr);
System.Console.WriteLine();
PrintArray(AriphmetickArr);
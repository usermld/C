/*
51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int[,] Get2DArray (int row, int col)
{
    int[,] array = new int [row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray (int[,] arr)
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

int[,] Search (int[,] arr)
{
    int result = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       result += arr[i, i];
    }
    return result; // просит преобразовать из int в int[*, *]
}

void Print2DArray2 (int[,] arr)
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

int[,] user2DArray = Get2DArray (5, 9);
Print2DArray(user2DArray);
int[,] ua2 = Search(user2DArray);
System.Console.WriteLine();
Print2DArray2(ua2);
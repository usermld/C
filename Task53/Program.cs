/*
53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

int[,] array(int row, int col)
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

void PrintArray(int[,] arr)
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


void SwapRoads (int [,] arr)
{
    int[] temp = new int[arr.GetLength(1)];

    for (int i = 0; i < temp.Length; i++)
    {
        temp[i] = arr[0, i];
        arr[0, i] = arr[arr.GetLength(0) - 1, i];
    }

    for (int i = 0; i < temp.Length; i++)
    {
        arr[arr.GetLength(0) - 1, i] = temp[i];
    }

}

void PrintSwapRoads(int[,] arr)
{
    System.Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int roads = new Random().Next(0, 11);
int cols = new Random().Next(0, 11);
int[,] userArr = array (roads, cols);
PrintArray(userArr);
SwapRoads(userArr);
PrintSwapRoads(userArr);
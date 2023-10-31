/*
47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
*/ 

/*double[,] Get2DArray (int row, int cow)
{
    double[,] array = new double[row, cow];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}*/

void PrintArray (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
            if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
            {
                System.Console.WriteLine($"m = {i + 1}, n = {j + 1}, minLimitRandom = -10, maxLimitRandom = 10");
            }
        }
        System.Console.WriteLine();
    }
}

double[,] CreateRandomMatrix (int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
        }
    }
    return array;
}

double[,] userArr = CreateRandomMatrix(3,3);
PrintArray(userArr);
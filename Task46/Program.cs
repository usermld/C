/*
46. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/

Console.Clear();

int[,] Get2DArray (int row, int col)
{
    int[,] array = new int [row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
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

int row = new Random().Next(0, 10);
int col = new Random().Next(0, 10);

int[,] user2DArray = Get2DArray (row, col); // можно удалить 32 и 33 строчку и в аргумент метода вставить фиксированные значения
Print2DArray(user2DArray);
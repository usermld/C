/*
50. Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1 и 2 -> 2
1 и 7 -> такого числа в массиве нет
*/

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

void Search(int[,] arr, int col, int row)
{
    int sCol = 0;
    int sRow = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == col - 1 && j == row - 1)
            {
                System.Console.WriteLine($"{arr[i + 1, j + 1]} - этот элемент в массиве");
                sCol = i;
                sRow = j;
            }
        }
    }
    if (sCol == 0 && sRow == 0)
    {
        System.Console.WriteLine("Нет элемента с данным значением");
    }
}

int row = new Random().Next(2, 10);
int col = new Random().Next(0, 10);
System.Console.WriteLine($"{row} {col} - значения массива");

int row1 = new Random().Next(0, 10);
int col1 = new Random().Next(0, 10);
System.Console.WriteLine($"{row1} {col1} - элемент этого массива");

int[,] user2DArray = Get2DArray(row, col); // можно удалить 32 и 33 строчку и в аргумент метода вставить фиксированные значения
Print2DArray(user2DArray);
Search(user2DArray, row1, col1);
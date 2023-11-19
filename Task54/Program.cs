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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


int[,] SortRowsDescending(int[,] matrix)
{
    
    int[,] array = new int[3, 3];
     for (int i1 = 0; i1 < 3; i1++)
     {
         for (int j1 = 0; j1 < 3; j1++)
         {
             array[i1, j1] = new Random().Next(0, 0);
         }
     }

/*
     int[,] array_count = new int[3, 3];
     for (int i1 = 0; i1 < 3; i1++)
     {
         for (int j1 = 0; j1 < 3; j1++)
         {
             array[i1, j1] = new Random().Next(0, 0);
         }
     }
     */


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            /* for (int k = 0; k < array.GetLength(0); k++)
             {
                 for (int m = 0; m < array.GetLength(1); m++)
                 {
                     for (int h = 0; h < matrix.GetLength(0) ; h++)
                     {

                         if (matrix[i, j] > matrix )
                         {
                             array_count[k,m] = array[k, m];
                             matrix [i, j] = array_count[k,m];
                         }
                     }

                 }

             }
             */

            for (int h = 0; h < matrix.GetLength(0); h++)
            {
                if (matrix[i, j] > matrix[h, h])
                {
                    array[h, h] = matrix[h, h];
                    matrix[i,j] = array [h, h];
                }
    
            }

        }
    }

    return matrix;
}

void PrintMatrixSort(int[,] matrix)
{
    System.Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int[,] user_array = array(3, 3);
PrintMatrix(user_array);
int[,] user_array_sort = SortRowsDescending(user_array);
PrintMatrixSort(user_array_sort);
/*
не испоьзуя рекурсия показать путь к числу N
5 - 0 1 1 2 3  
*/

void Search(int numN)
{
    int[] febonacci = new int[numN + 1];

    if (numN == 0) System.Console.WriteLine("1");
    else
    {
        for (int i = 0; i < 2; i++)
        {
            febonacci[i] = i;
            System.Console.Write(febonacci[i] + " ");
        }
        for (int i = 2; i < numN; i++)
        {
            febonacci[i] = febonacci[i - 2] + febonacci[i - 1];
            System.Console.Write(febonacci[i] + " ");
        }
    }
}

Search(21);
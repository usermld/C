/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Akkerman (int num_1, int num_2)
{
    if (num_1 == 0)
    {
        return num_2 + 1;
    }

       if (num_1 > 0 && num_2 == 0) 
       {
        return Akkerman(num_1 - 1, 1);
       }

       if (num_1 > 0 && num_2 > 0)
       {
        return Akkerman(num_1 -1, Akkerman(num_1, num_2 -1));
       }
       return 0;

}

int u_num = Akkerman(3, 2);
System.Console.WriteLine(u_num);


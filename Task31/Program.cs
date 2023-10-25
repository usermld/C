﻿/*
31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
 Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
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

void Sum(int[] arr)
{
    int sum = 0;
    int sum1 =0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i];
        else sum1 += arr[i];
    }
    System.Console.WriteLine(sum);
    System.Console.WriteLine(sum1);
}

int[] userArray = MakeArr(12);
PrintArray(userArray);
System.Console.WriteLine();
Sum(userArray);
    
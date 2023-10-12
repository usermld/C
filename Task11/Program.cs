/*
Напишите программу, которая выводит случайное 3х значное число и удалаяет 2ю цифру этого числа
*/

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int num1 = number / 100;
int num2 = number % 10;
int resalt = num1 * 10 + num2;

System.Console.WriteLine(resalt);
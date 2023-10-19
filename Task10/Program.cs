﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(1, 10000);
System.Console.WriteLine(number);

if (number > 0 && number < 10) {
    System.Console.WriteLine("Это цифра");
    System.Console.WriteLine("0");
}
else if (number > 10 && number < 100) {
    System.Console.WriteLine("Число 2х значное");
    int num = number % 10;
    System.Console.WriteLine($"2я цифра - {num}");
}
else if (number > 100 && number < 1000) {
    System.Console.WriteLine("Число 3х значное");
    int num = number % 100 / 10;
    System.Console.WriteLine($"2я цифра - {num}");
}
else if (number > 1000 && number < 10000) {
    System.Console.WriteLine("Число 5и значное");
    int num = number % 1000 / 100;
    System.Console.WriteLine($"2я цифра - {num}");
}
else if (number < 0) {
    System.Console.WriteLine("Число меньше нуля");
} 
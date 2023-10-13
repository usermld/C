/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/ 

int number = new Random().Next(-100, 100000);
System.Console.WriteLine(number);

if (number > 0 && number < 10) {
    System.Console.WriteLine("Это цифра");
    System.Console.WriteLine("третьей цифры нет");
}
else if (number > 10 && number < 100) {
    System.Console.WriteLine("Число 2х значное");
    System.Console.WriteLine("третьей цифры нет");
}
else if (number > 100 && number < 1000) {
    System.Console.WriteLine("Число 3х значное");
    int num = number % 10;
    System.Console.WriteLine($"3я цифра - {num}");
}
else if (number > 1000 && number < 10000) {
    System.Console.WriteLine("Число 4х значное");
    int num = number % 100 / 10;
    System.Console.WriteLine($"3я цифра - {num}");
}
else if (number > 10000 && number < 100000) {
    System.Console.WriteLine("Число 5и значное");
    int num = number % 1000 / 100;
    System.Console.WriteLine($"3я цифра - {num}");
}
else if (number < 0) {
    System.Console.WriteLine("Число меньше нуля");
}
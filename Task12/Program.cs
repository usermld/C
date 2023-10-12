/*
Напишите прогу которая принимает на вход 2 числа и выводит является ли 2ое число кратным 1му, если да, то прога выводит остаток от деления
*/

System.Console.WriteLine("Введите 1ое число");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2ое число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 % number1 == 0) {
    System.Console.WriteLine("Работает");
    int num = number2 / number1;
    System.Console.WriteLine(num);
}
else {
    System.Console.WriteLine("Не работает");
}
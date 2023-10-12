/*
Напишите прогу которая принимает на вход 2 числа и проверяет является ли одно квадратом другого
*/

System.Console.WriteLine("Введите 1ое число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите 2ое число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2 || num2 == num1 * num1) {
    System.Console.WriteLine("Одно из чисел квадрат другого");
}
else {
    System.Console.WriteLine("не-а");
}
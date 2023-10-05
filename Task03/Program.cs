/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 -> Пятница
*/

System.Console.WriteLine("Введинете номер дня: ");
int number = Convert.ToInt32(Console.ReadLine ());

if (number == 1)
{
    System.Console.WriteLine ("monday");
}
if (number == 2)
{
    System.Console.WriteLine ("tuesday");
}
if (number == 3)
{
    System.Console.WriteLine ("wensday");
}
if (number == 4)
{
    System.Console.WriteLine ("thirday");
}
if (number == 5)
{
    System.Console.WriteLine ("friday");
}
if (number == 6)
{
    System.Console.WriteLine ("satutday");
}
if (number == 7)
{
    System.Console.WriteLine ("sunday");
}
if (number < 1 || number > 7 )
{
    System.Console.WriteLine("Нет такого дня");
}
int num = int.Parse(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WriteLine("Число '" + num + "' чётное");
}
else
{
    Console.WriteLine("Число '" + num + "' нечётное");
}
/*
Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

int FindMax = 0;
int a = Convert.ToInt32(Console.ReadLine ());
int b = Convert.ToInt32(Console.ReadLine ());
int c = Convert.ToInt32(Console.ReadLine ());

if ((a > b) & (a > c)) {
  FindMax = a;
}
    if ((b > a) & (b > c)) {
  FindMax = b;
}
    else{
      FindMax = c;
    }
System.Console.WriteLine(FindMax);
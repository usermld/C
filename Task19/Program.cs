System.Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number < 9999 || number > 100000) {
    System.Console.WriteLine("Число не пятизначное");
}

int n1 = number % 10;
int n2 = number / 10 % 10;
int n3 = number / 100 % 10;
int n4 = number / 1000% 10;
int n5 = number / 10000 % 10;

int num = (n1 * 10000) + (n2 * 1000) + (n3 * 100) + (n4 * 10) + n5; 

if (num == number) {
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
}
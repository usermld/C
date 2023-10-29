/*
напишите прогу которая на вход принимает 3 числа и проверяет может ли существовать треугольник с данными значениями
*/

/*bool Triangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && a + b > c)
    {
        return true;
    }
    return false;
}
*/
System.Console.WriteLine(Triangle(1, 2, 3));

string Triangle1(int a, int b, int c)
{
    string result = $"нет, треугольник со сторонами {a}, {b}, {c} - не существует";
    if (a + b > c && b + c > a && a + b > c)
    {
        result = $"да, это треугольник со сторонами {a}, {b}, {c} - существует";
    }
    return result;
}
System.Console.WriteLine(Triangle1(1, 2, 3));
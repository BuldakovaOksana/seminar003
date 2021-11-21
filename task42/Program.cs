// Выяснить являются ли три числа сторонами треугольника


void IsTriangle(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        System.Console.WriteLine("Являются треугольником");
    }
    else
    {
        System.Console.WriteLine("Не являются треугольником");
    }
}
IsTriangle(3, 4, 1);
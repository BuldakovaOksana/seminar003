// Ввести номер четверти, показать диапазоны для возможных координат



System.Console.WriteLine("Введите номер четверти");
int a = int.Parse(Console.ReadLine());

void showRange(int a)
{
if (a > 0 && a < 5)
{
    if (a == 1)
    {
        System.Console.WriteLine("Диапазон: x>0 & y>0");
    }
    if (a == 2)
    {
        System.Console.WriteLine("Диапазон: x<0 & y>0");
    }
    if (a == 3)
    {
        System.Console.WriteLine("Диапазон: x<0 & y<0");
    }
    if (a == 4)
    {
        System.Console.WriteLine("Диапазон: x>0 & y<0");
    }
}
else
{
    System.Console.WriteLine("Введите цыфру от 1 до 4");
}
}
showRange(a);

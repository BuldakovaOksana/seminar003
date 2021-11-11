// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.WriteLine("Ввудите x ");
int x = int.Parse(Console.ReadLine());
System.Console.WriteLine("Ввудите y ");
int y = int.Parse(Console.ReadLine());


if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("Первая четверть");
    }
    if (x < 0 && y > 0)
    {
        System.Console.WriteLine("Вторая четверть");
    }
    if (x < 0 && y < 0)
    {
        System.Console.WriteLine("Третья четверть");
    }
    if (x > 0 && y < 0)
    {
        System.Console.WriteLine("Четвертая четверть");
    }

}
else
{
    System.Console.WriteLine("X и Y не могут быть равны 0");
}

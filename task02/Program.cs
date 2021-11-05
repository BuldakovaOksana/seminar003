// По двум введённым числам проверять является ли первое квадратом второго



Console.Write("Введите первое число и нажмите клавишу Enter: ");
string first = Console.ReadLine();
int firstnumber = Convert.ToInt32(first);

Console.Write("Введите второе число и нажмите клавишу Enter: ");
string second = Console.ReadLine();
int secondnumber = Convert.ToInt32(second);
Console.WriteLine($"Первое число  {firstnumber}");
Console.WriteLine($"Второе число  {secondnumber}");
if (firstnumber == secondnumber * secondnumber)
{
    Console.WriteLine("Является квадратом");
}
else
{
    Console.WriteLine("Не является квадратом");
}

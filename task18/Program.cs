// По двум введённым числам проверять является ли одно квадратом другого

System.Console.WriteLine("Введите первое число ");
int numberFirst=int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число ");
int numberSecond=int.Parse(Console.ReadLine());

void numberX(int numberFirst, int numberSecond)
{

if (numberFirst==numberSecond*numberSecond)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else
{
    System.Console.WriteLine("Первое число не является квадратом второго");
}

if (numberSecond==numberFirst*numberFirst)
{
    System.Console.WriteLine("Второе число является квадратом первого");
}
else
{
    System.Console.WriteLine("Второе число не является квадратом первого");
}
}
numberX(numberFirst, numberSecond );
// Показать вторую цифру трёхзначного числа
System.Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine());

int secondDigit(int a)
{
    int result = a / 10 % 10;
    return result;
}
int b = secondDigit(a);
System.Console.WriteLine($"Второе число {b}");
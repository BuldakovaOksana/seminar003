// Удалить вторую цифру трёхзначного числа


int a = new Random().Next(100, 1000);
System.Console.WriteLine(a);

int deleteDigit(int a)
{
    int b = a / 100 * 10 + a % 10;
    return b;
}
int result = deleteDigit(a);
System.Console.WriteLine(result);
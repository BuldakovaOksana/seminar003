// Показать последнюю цифру трёхзначного числа

System.Console.WriteLine("Введите трехзначное число");
int a= int.Parse(Console.ReadLine());

int lastDigit(int a)
{
    int result= a%10;
    return result;
}
int b=lastDigit(a);
System.Console.WriteLine(b);
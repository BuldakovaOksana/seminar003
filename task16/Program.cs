//  Дано число. Проверить кратно ли оно 7 и 23


int number = new Random().Next(1, 1000);
System.Console.WriteLine(number);
int a = 7;
int b = 23;

void multiplicity(int number, int a, int b)
{
    if (number % a == 0 && number % b == 0)
    {
        System.Console.WriteLine("Кратно");
    }
    else
    {
        System.Console.WriteLine("Не кратно");
    }
}
multiplicity(number, a, b);

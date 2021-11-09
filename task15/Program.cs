// Найти третью цифру числа или сообщить, что её нет*/ 


int number = new Random().Next(1, 100);
System.Console.WriteLine(number);

if (number < 100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    int a = number / 100 % 10;
    System.Console.WriteLine($"Третья цифра {a}");
}





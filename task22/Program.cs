// Программа проверяет пятизначное число на палиндромом.



int number=new Random().Next(10000,100000);

int digitFirst= number/10000;
int digitSecond=number/1000%10;
int digitFourth=number/10%10;
int digitFifth=number%10;
System.Console.WriteLine($"{number} ");
System.Console.Write($"{digitFirst} {digitSecond} {digitFourth} {digitFifth} ");

if (digitFirst==digitFifth&&digitSecond==digitFourth)
{
    System.Console.WriteLine("Палиндромом");
}
else
{
    System.Console.WriteLine("Не палиндромом");
}

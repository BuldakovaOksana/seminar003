// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа


int number = new Random().Next(10, 100);
//System.Console.WriteLine(number);

int findMax(int number)
{
    int a = number / 10;
    int b = number % 10;
    int max=0;
    if (a > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    return max;
}
int result=findMax(number);
System.Console.WriteLine($"{result} наибольшая цифра числа {number}");
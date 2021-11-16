// Определить количество цифр в числе

int determineQuantity(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
int result = determineQuantity(12345678);
System.Console.WriteLine(result);



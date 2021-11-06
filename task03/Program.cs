// Даны два числа. Показать большее и меньшее число

int a=55;
int b=9;
if (a>b)
{
    int max=a;
    int min=b;
    Console.WriteLine($"Max = {max}  Min = {min}");
}
else
{
    int max=b;
    int min=a;
    Console.WriteLine($"Max = {max}  Min = {min}"); 
}

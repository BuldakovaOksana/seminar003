// Найти сумму чисел от 1 до А

// int a=0;
// for (int i = 0; i < 10; i++)
// {
//     a=a+i;
//     System.Console.WriteLine($"{i} {a}");
// }



int sum( int number)
{
int a=0;
for (int i = 0; i < number; i++)
{
    a=a+i;
    
}
return a;
}
int result=sum(10);
System.Console.WriteLine(result);
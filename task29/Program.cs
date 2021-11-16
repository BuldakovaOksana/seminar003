// Подсчитать сумму цифр в числе


int calculateAmount(int number)
{
int sum=0;
while (number>0)
{
     sum=sum+number%10;
     number=number/10;
}
return sum;
}
int result=calculateAmount(234);
System.Console.WriteLine(result);

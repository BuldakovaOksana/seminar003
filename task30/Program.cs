// Написать программу вычисления произведения чисел от 1 до N



int productsNumbers(int N)
{
int product=1;
for (int i = 1; i <= N; i++)
{
    product=product*i;
}
return product;
}
int result= productsNumbers(5);
System.Console.WriteLine(result);
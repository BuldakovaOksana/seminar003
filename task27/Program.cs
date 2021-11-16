// Возведите число А в натуральную степень B используя цикл


int exponentiationNumber(int numberA, int power)
{

int variable=1;

for (int i = 0; i < power; i++)
{
    variable=variable*numberA;
}
return variable;
}
int result=exponentiationNumber(5,5);
System.Console.WriteLine(result);
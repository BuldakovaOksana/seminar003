// Выяснить, кратно ли число заданному, если нет, вывести остаток.


int numberFirst=new Random().Next(100,1000);
int numberSecond=new Random().Next(1,10);

System.Console.WriteLine($"Делимое {numberFirst}");
System.Console.WriteLine($"Делитель {numberSecond}");

int withdrawRemainder( int numberFirst, int numberSecond)
{
if (numberFirst%numberSecond==0) 
{
    int b=0;
System.Console.WriteLine("Кратно");
return b;
}
else 
{
    int a= numberFirst%numberSecond;
    return a;
}
}
int result=withdrawRemainder ( numberFirst, numberSecond);
System.Console.WriteLine($"Остаток {result}");
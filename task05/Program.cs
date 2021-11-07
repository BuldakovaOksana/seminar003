// Найти максимальное из трех чисел


int [] array= new int[3];
for (int i = 0; i < array.Length; i++)
{
 array[i]=new Random().Next(1,10);
 Console.Write($"{array[i]} ");   
}
Console.WriteLine();

int max=array[0];
for (int i = 0; i < array.Length; i++)
{
if (max<array[i])
{
    max=array[i];
    
}
}

 Console.WriteLine(max);   
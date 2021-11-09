// Показать четные числа от 1 до N


int[]array=new int[10];

for (int i = 0; i < array.Length; i++)
{
    array [i]=new Random().Next(1,100);
    
    System.Console.Write($"{array[i]} ");
}
 System.Console.WriteLine();

 for (int i = 0; i < array.Length; i++)
 {
     if (array[i]%2==0)
     {
         System.Console.Write($"{array[i]} ");
     }
 }
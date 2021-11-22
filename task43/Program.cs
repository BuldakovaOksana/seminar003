// Определить сколько чисел больше 0 введено с клавиатуры

System.Console.WriteLine("ВВедите число ");

    int[] array=new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=int.Parse(Console.ReadLine());
    
    }
    

int EnteredNumbersMoreZero(int[] arr)
{
int count=0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i]>0)
    {
        count++;
    }
    }
    return count;
}
int result=EnteredNumbersMoreZero(array);
System.Console.WriteLine($"Чисел > 0 = {result}");
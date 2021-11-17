// Задать массив из 8 элементов и вывести их на экран 



void PrintArray()
{
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 20);
    System.Console.WriteLine(array[i]);
}
}
PrintArray();
// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран



// void PrintArray()
// {
//     int[]array=new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//      array[i]=new Random().Next(0,2);
//      System.Console.WriteLine(array[i]);   
//     }
// }
// PrintArray();



int[] array=new int [8];
int [] FillArray(int [] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i]=new Random().Next(0,2);
    }
    return A;
}


string PrintArray(int [] B)
{
    string result = string.Empty;
    for (int i = 0; i < B.Length; i++)
    {
       result += $"{B[i]} ";
    }
    return result;
}


FillArray(array);
string print=PrintArray(array);
System.Console.WriteLine(print);
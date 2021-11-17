// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива



int[] array = new int[12];

int[] FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(-9, 10);
        //System.Console.WriteLine(A[i]);
    }
    return A;
}

string PrintArray(int[] B)
{
    string result = string.Empty;
    for (int i = 0; i < B.Length; i++)
    {
        result += $"{B[i]} ";
    }
    return result;
}

 FillArray(array);
string print = PrintArray(array);
System.Console.WriteLine(print);

int positive = 0;
int negative = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        positive += array[i];
    }
    else
    {
        negative += array[i];
    }
}

System.Console.WriteLine(positive);
System.Console.WriteLine(negative);


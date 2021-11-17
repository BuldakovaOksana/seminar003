//  В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


int[] array = new int[123];

int[] FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(-50, 200);
    }
    return A;
}


string PrintArray(int[] B)
{
    string res = string.Empty;
    for (int i = 0; i < B.Length; i++)
    {
        res += $"{B[i]} ";
    }
    return res;
}

FillArray(array);
string result = PrintArray(array);
System.Console.WriteLine(result);
System.Console.WriteLine();
int findElements(int[] C)
{
    int count = 0;
    for (int i = 0; i < C.Length; i++)
    {
        if (C[i] > 10 && C[i] < 100)
        {
            count++;
        }
    }
    return count;
}
int ElementCount=findElements(array);
System.Console.WriteLine(ElementCount);
// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.



int[] array = new int[10];

int[] FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(1, 11);
        System.Console.Write(A[i] + " ");
    }
    return A;
}
FillArray(array);

System.Console.WriteLine();

string productsPairs(int[] B)
{
    int j = B.Length - 1;
    string result = string.Empty;
    for (int i = 0; i < B.Length / 2; i++)
    {
        result += array[i] * array[B.Length - 1 - i] + " ";
    }
    return result;
}
string res = productsPairs(array);
System.Console.WriteLine(res);
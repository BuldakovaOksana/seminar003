// Найти сумму чисел одномерного массива стоящих на нечетной позиции


int[] array = new int[10];

int[] FillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(1, 10);
        System.Console.Write($"{A[i]} ");
    }
    return A;
}
FillArray(array);

System.Console.WriteLine();
int sumNumbers(int[] A)
{
    int sum = 0;
    for (int i = 0; i < A.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += A[i];
        }

    }
    return sum;
}

int result = sumNumbers(array);
System.Console.WriteLine(result);
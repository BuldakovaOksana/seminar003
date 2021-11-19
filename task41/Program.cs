//  В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


double[] FilArray(int size, int min, int max) //double min, double max
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);

    }
    return array;
}
double[] result = FilArray(10, -5, 5);


void PrintArray(double[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        System.Console.WriteLine(A[i]);
    }
}
PrintArray(result);


double difference(double[] B)
{
    double max = 0;
    double min = 0;
    for (int i = 0; i < B.Length; i++)
    {
        if (B[i] > max)
        {
            max = B[i];

        }

        if (B[i] < min)
        {
            min = B[i];

        }

    }
    System.Console.WriteLine("min = " + min);
    System.Console.WriteLine("max = " + max);
    return max - min;
}
double diff = difference(result);
System.Console.WriteLine("разница " + diff);
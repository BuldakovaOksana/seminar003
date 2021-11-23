// Написать программу копирования массива


int[] FillArray(int size, int LeftBound, int RightBound)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(LeftBound, RightBound);
    }
    return array;
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
int[] array = FillArray(10, 1, 100);
System.Console.Write("Оригинал массива: ");
PrintArray(array);
System.Console.WriteLine();

int[] CopyArray(int[] array)
{
    int[] arrayB = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayB[i] = array[i];

    }
    return arrayB;
}
int[] result = CopyArray(array);
System.Console.Write("Копия массива: ");
PrintArray(result);

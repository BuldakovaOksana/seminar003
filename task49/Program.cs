// Показать двумерный массив размером m×n заполненный целыми числами


int[,] FillArray(int a, int b, int LeftBound, int RightBound)
{
    int[,] array = new int[a, b];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = new Random().Next(LeftBound, RightBound);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]+ " ");
        }
        System.Console.WriteLine();
    }
}
int[,] array = FillArray(4, 4, 10, 100);
PrintArray(array);
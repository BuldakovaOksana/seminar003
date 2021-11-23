// Показать двумерный массив размером m×n заполненный вещественными числами



double[,] FillArray(int a, int b, double LeftBound, double RightBound)
{
    double[,] array = new double[a, b];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = new Random().NextDouble(LeftBound, RightBound);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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
double[,] array = FillArray(4, 4, 0,1 );
PrintArray(array);
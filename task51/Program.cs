// В двумерном массиве n×k заменить четные элементы на противоположные


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
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}

int[,] result = FillArray(4, 4, 10, 100);
PrintArray(result);
System.Console.WriteLine();

int[,] ReplaceEvenWithOpposite(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]%2==0)
            {
                array[i,j]=-array[i,j];
            }
        }
    }
    return array;
}
int [,] opposite= ReplaceEvenWithOpposite(result);
PrintArray(opposite);
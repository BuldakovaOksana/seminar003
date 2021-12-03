// Написать программу, которая обменивает элементы первой строки и последней строки




int[,] FillArray(int row, int column, int leftBound, int rightBound)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(leftBound, rightBound);
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


int[,] GetArray = FillArray(4, 4, 1, 10);
PrintArray(GetArray);


int[,] ExchangeFirstrowLastrow(int[,] array)
{

    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int tamp = array[i, j];
        array[i, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = tamp;
    }


    return array;
}
int[,] Exchange = ExchangeFirstrowLastrow(GetArray);
System.Console.WriteLine();
PrintArray(Exchange);
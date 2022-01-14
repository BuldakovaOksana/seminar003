// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


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
int[,] GetArray = FillArray(4, 6, 1, 10);
PrintArray(GetArray);


int[,] ArrangeRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                int max = j;
                if (array[i, k] > array[i, max])
                {
                    max = k;
                    int temp = array[i, j];
                    array[i, j] = array[i, max];
                    array[i, max] = temp;

                }
            }
        }
    }
    return array;
}
int[,] result = ArrangeRow(GetArray);
System.Console.WriteLine();
PrintArray(result);
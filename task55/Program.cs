// В матрице чисел найти сумму элементов главной диагонали


int[,] GetArray(int row, int column, int leftBound, int rightBound)
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


void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] FillArray=GetArray(5,5,1,10);
PrintArray(FillArray);

int GetSumDiagonals(int[,] array)
{
    int sum=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum+=array[i,i];
    }
    return sum;
}
System.Console.WriteLine(GetSumDiagonals(FillArray));

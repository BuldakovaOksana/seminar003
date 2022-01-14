// В прямоугольной матрице найти строку с наименьшей суммой элементов.


int[,] FillArray(int row, int column, int leftBound, int rightBound)
{
    int[,] Array=new int [row, column];
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
         Array[i,j]=new Random().Next(leftBound, rightBound);   
        }
    }
    return Array;
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

int[,] Array= FillArray(4,6,1,10);
PrintArray(Array);

int[] GetSummElementsRow(int[,] array)
{
    int[] SummArray=new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summrow=0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summrow=summrow + array[i,j];
           
        }
        SummArray[i]=summrow;
    }
    return SummArray;
}

System.Console.WriteLine();
void PrintSummArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}
int[] summArray=GetSummElementsRow(Array);
PrintSummArray(summArray);

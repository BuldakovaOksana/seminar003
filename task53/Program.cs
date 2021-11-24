// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты



int[,] FillArray(int row, int column, int LeftBound, int RightBound)
{
    int[,]array=new int[row,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(LeftBound, RightBound);
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
            System.Console.Write(array[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}  
int[,]array=FillArray(4,4,10,100);
PrintArray(array);

System.Console.WriteLine();
int [,] ReplaceEvenWithSquare(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)
            {
                array[i,j]=array[i,j]*array[i,j];
            }
        }
    }
    return array;
}


int[,] result=ReplaceEvenWithSquare(array);
PrintArray(result);
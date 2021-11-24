// Задать двумерный массив следующим правилом: Aₘₙ = m+n



int[,] FillArray(int row, int column)
{
    int[,]array=new int[row,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=i+j;
            
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
int[,]array=FillArray(4,4);
PrintArray(array);

FillArray(4,4);
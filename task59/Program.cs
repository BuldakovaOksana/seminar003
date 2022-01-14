// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).


int [,] FillArray (int row, int column, int leftBound, int rightBound)
{
    int [,] array= new int [ row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j]= new Random().Next(leftBound, rightBound);
        }
    }
    return array;
}


void PrintArray( int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array [i,j]}  ");
        }
        System.Console.WriteLine();
    }
}

int [,] Array= FillArray(5, 5, 1, 10);
PrintArray(Array);
System.Console.WriteLine();

int [,] ChengeRowOnColumn(int [,] array)
{ //int j = 0;
    for (int i = 0;  i < array.GetLength(0); i++)
    {
          for (int j = i; j < array.GetLength(1); j++)
          {
            int temp=array[i,j];
          array[i,j]=array[j,i];
          array[j,i]=temp;
          
         }
    }
    return array;
}
int [,] ChengeArray=ChengeRowOnColumn(Array);
PrintArray(ChengeArray);

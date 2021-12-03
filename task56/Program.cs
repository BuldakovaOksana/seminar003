// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.


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

int[,] getArray = FillArray(4, 4, 1, 10);
PrintArray(getArray);

void ArithmeticMeanColumn(int[,] array)
{
    double[] arr = new double[array.GetLength(1)];
    //double sum=0;
    
    //double arithmeticMean = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];

            // System.Console.Write(sum + " ");
            //arithmeticMean = sum / 5;
            //arr[j] = arithmeticMean;
        }
        
      System.Console.Write($"{arr[j] = sum / array.GetLength(0)} ");
    }
    
}    
ArithmeticMeanColumn(getArray);

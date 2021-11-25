// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет



int[,] FillArray(int row, int column, int LeftBound, int RightBound)
{
    int[,] array = new int[row, column];
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



   




void ShowPositionNumber(int[,] array, int number)
{
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                count++;

                System.Console.WriteLine($"Позиции числа[{i},{j}] ");
            }


        }
    }
    if (count <= 0)
    {
        System.Console.WriteLine("Такого элемента нет");
    }
}

System.Console.WriteLine("Введите число для проверки ");
 int number=int.Parse(Console.ReadLine());

int[,] array = FillArray(4, 4, 1, 100);
PrintArray(array);
System.Console.WriteLine();
ShowPositionNumber(array, number);

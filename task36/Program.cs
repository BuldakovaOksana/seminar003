// Определить, присутствует ли в заданном массиве, некоторое число 


int[] array = new int[10];

int[] fillarray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(1, 10);
    }
    return A;
}


string printarray(int[] B)
{
    string res = string.Empty;
    for (int i = 0; i < B.Length; i++)
    {
        res += $"{B[i]} ";
    }
    return res;
}

fillarray(array);
string print = printarray(array);
System.Console.WriteLine(print);
System.Console.WriteLine();


void identifyPresent(int[] C, int number)
{
    for (int i = 0; i < C.Length; i++)
    {
        if (C[i] == number)
        {

            System.Console.WriteLine($"Число присутствует под индексом № {i}");
        }

    }

}

identifyPresent(array, 7);

// Написать программу замену элементов массива на противоположные


int[] array = new int[10];

int[] fillarray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(-10, 11);
    }
    return A;
}


string printarray(int[] B)
{
    string print = string.Empty;
    for (int i = 0; i < B.Length; i++)
    {
        print += $"{B[i]} ";
    }
    return print;
}
fillarray(array);
string result = printarray(array);
System.Console.WriteLine(result);
System.Console.WriteLine();

string replacingVariable(int[] b)
{
    string res = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        res += b[i] * -1 + " ";
        
    }
    return res;
}

string A = replacingVariable(array);
System.Console.Write(A + " ");
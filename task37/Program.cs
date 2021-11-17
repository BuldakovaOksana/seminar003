// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел


int[] array = new int[10];

int[] fillArray(int[] A)
{
    for (int i = 0; i < A.Length; i++)
    {
        A[i] = new Random().Next(100, 1000);
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

fillArray(array);
string result = printarray(array);
System.Console.WriteLine(result);


int even = 0;
int odd = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
}

System.Console.WriteLine($"Четных {even} нечетных {odd} ");
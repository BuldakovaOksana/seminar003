// Показать числа Фибоначчи


void Fibonacci(int number)
{
    int A = 0;
    int B = 1;
    int C = 0;
    for (int i = 0; i < number; i++)
    {
        C = A + B;
        A = B;
        B = C;
        System.Console.WriteLine(A);
    }

}
Fibonacci(10);

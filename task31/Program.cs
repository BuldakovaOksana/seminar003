// Показать кубы чисел, заканчивающихся на четную цифру



for (int i = 1; i < 10; i++)
{
    int cube =i*i*i;
    if (cube%2==0)
    {
        System.Console.WriteLine(cube);
    }
}

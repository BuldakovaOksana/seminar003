// Написать программу преобразования десятичного числа в двоичное

string BinaryNumber(int number)
{

    string binaryNum = string.Empty;

    while (number > 0)
    {
        binaryNum += number % 2;
        number = number / 2;

    }
    return binaryNum;
}
string result = BinaryNumber(27);
System.Console.WriteLine(result);
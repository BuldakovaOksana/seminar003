// Дано число обозначающее день недели. Выяснить является номер недели выходным днём

System.Console.WriteLine("Введите число обозначающее день недели");
int number = int.Parse(Console.ReadLine());
int a = Convert.ToInt32(number);

if (a<1 || a > 7) 
{System.Console.WriteLine("Введите цифру от 1 до 7");}
else
{
    
if (a <= 5) System.Console.WriteLine("Рабочий день!");
if (a>=6)  System.Console.WriteLine("Выходной день!");
}

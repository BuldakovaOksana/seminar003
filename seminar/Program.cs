// ## Консольная игра "Угадай число" Комп загадывает число (в некотором отрезке), у игрока есть несколько попыток, чтобы угадать это число 
// Игрок вводит различные числа, комп считает количество попыток, а также "говорит" введенное число больше или меньше загаданного. 
 
// 1. Нам необходимо задать исходные (обозначить условия). Отрезок (минимальное и максимальное значение), количество попыток. 
// Один способ - задать как константы, второй способ - запросить у игрока.
//  2. Инициализировать игру. Загадываем число и приветсвуем игрока, объясняем условия игры. 
//  3. Делаем ход. Запрашиваем и получаем от игрока число. Сравниваем это число с загаданным, изменяем количество попыток и выводим результат. 
//  4. Завершение игры (Если человек угадал, либо потратил все попытки). Либо предложить сыграть еще раз.
// * GameInit() - метод, который задает все исходные значения в вашей игре. * MakeMove() - ходы, задаются этим методом. 
// * RequestNumber() - запрос числа у игрока, обработка нештатных ситуаций. * CheckNumber(int PlayesrNumber, int SecretNumber) 
// * GameOver(bool winner) -



int LeftBound=1; 
int RightBound=100;
int attempts=7;

void GameInit(int LeftBound, int RightBound, int attempts)
{
   System.Console.WriteLine($"Привет! Давай поиграем в игру, Угадай число. Я загадаю число в отрезки от {LeftBound} до {RightBound}, а ты его угадаешь за {attempts} попыток.");
}
GameInit(LeftBound, RightBound, attempts);

int MakeNumber(int LeftBound, int RightBound)
{
int number=new Random().Next(LeftBound, RightBound);
return number;
}
int SecretNumber=MakeNumber(1,100);
System.Console.WriteLine(SecretNumber);

System.Console.WriteLine("Какое число я загадал? Ввуди число: ");

int EnterNumber()
{ int PlayesrNumber=0;
    return  PlayesrNumber= int.Parse(Console.ReadLine()); 
}
int PlayesrNumber=EnterNumber();

int MakeMove(int PlayesrNumber, int SecretNumber, int attempts)
{
int count=attempts;
while (true)
{
     


    if (PlayesrNumber==SecretNumber)
    {
        System.Console.WriteLine("Вы выйграли!!!");
    }
    else
    {
        
    
    if (PlayesrNumber>SecretNumber)
    {
        System.Console.WriteLine("Ваше число больше загаданного");
    }
    if (PlayesrNumber<SecretNumber)
    {
        System.Console.WriteLine("Ваше число меньше загаданного");
    }
    }

}


// int GoThroughCycle(int attempts)
// {
// while (attempts>0)
// {
//     MakeMove(PlayesrNumber, SecretNumber, attempts);
//     attempts--;
// }

// return attempts;
// }
// int StillAttempts=GoThroughCycle(attempts);
 System.Console.WriteLine($"у вас осталось {StillAttempts}");
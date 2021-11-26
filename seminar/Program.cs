// ## Консольная игра "Угадай число" Комп загадывает число (в некотором отрезке), у игрока есть несколько попыток, чтобы угадать это число 
// Игрок вводит различные числа, комп считает количество попыток, а также "говорит" введенное число больше или меньше загаданного. 


int LeftBound = 1;
int RightBound = 100;
int attempts = 7;

void GameInit(int LeftBound, int RightBound, int attempts)
{
    System.Console.WriteLine($"Привет! Давай поиграем в игру, Угадай число. Я загадаю число в отрезки от {LeftBound} до {RightBound}, а ты его угадаешь за {attempts} попыток.");
}
GameInit(LeftBound, RightBound, attempts);

int MakeNumber(int LeftBound, int RightBound)
{
    int number = new Random().Next(LeftBound, RightBound);
    return number;
}
int SecretNumber = MakeNumber(1, 100);


int EnterNumber()
{
    int PlayesrNumber = 0;
    return PlayesrNumber = int.Parse(Console.ReadLine());
}


int MakeMove(int PlayesrNumber, int SecretNumber, int attempts)
{


    if (PlayesrNumber > SecretNumber)
    {
        System.Console.WriteLine("Ваше число больше загаданного");

    }
    if (PlayesrNumber < SecretNumber)
    {
        System.Console.WriteLine("Ваше число меньше загаданного");

    }
    attempts--;
    return attempts;

}


int GoThroughCycle(int attempts)
{
    while (attempts > 0)
    {
        System.Console.WriteLine("Какое число я загадал? Введи число: ");
        int PlayesrNumber = EnterNumber();
        if (PlayesrNumber == SecretNumber)
        {
            System.Console.WriteLine("Вы выиграли!!!");

            return attempts;
        }
        int move = MakeMove(PlayesrNumber, SecretNumber, attempts);
        attempts--;
        System.Console.WriteLine($"У вас осталось {attempts} попыток ");

        if (attempts <= 0)
        {
            System.Console.WriteLine("Вы проиграли!");
        }
    }


    return attempts;
}
GoThroughCycle(attempts);

System.Console.WriteLine($"Я загадал число {SecretNumber}");
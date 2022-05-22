// Task 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

void PowNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine(result);
}
/* PowNumber(3, 5);
PowNumber(2, 4); */

//Task 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void SumNumbers(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    Console.WriteLine(result);
}
/* SumNumbers(452);
SumNumbers(82);
SumNumbers(9012); */

//Task 3: Напишите программу, которая задаёт массив из 8 элементов случайными числами и 
//выводит их на экран. Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int[] NewArrayRandom(int count)
{
    int min = 1;
    int max = 100;
    int[] arr = new int[count];
    for (int i = 0; i < count; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

//PrintArray(NewArrayRandom(8));

// Добровольная задача: игра в угадайку

int RandomNumber()
{
    return new Random().Next(0, 100);
}

void compareAnswer(int answer, int userAnswer)
{
    if (answer == userAnswer)
    {
        Console.WriteLine($"Поздравляю, вы победили! Ваш ответ {userAnswer} верный!");
        Console.WriteLine();
        Environment.Exit(0);

    }
    else if (answer < userAnswer)
    {
        Console.WriteLine($"Введенное число {userAnswer} больше загаданного!");
    }
    else
    {
        Console.WriteLine($"Введенное число {userAnswer} меньше загаданного!");
    }
}

int ReadUserAnswer(string msg)
{
    Console.Write($"{msg} ");

    string text = Console.ReadLine();

    if ((text.Any(char.IsLetter) == false) & (text.Length < 3))
    {
        return int.Parse(text);
    }
    else
    {
        return -1;
    }

}

string helloUser(int maxAttempt)
{
    Console.Write("Привет, это игра в угадайку! Представтесь, пожалуйста: ");
    string name = Console.ReadLine();
    
    Console.WriteLine($"Здравствуйте, {name}! Давайте сыграем в игру! "
    + $"Загадано число от 0 до 99, у вас {maxAttempt} попыток его отгадать, "
    + "программа будет подсказывать больше или меньше ваш ответ относительно загаданного числа!");
    Console.WriteLine("Для продолжения нажмите клавишу Enter");
    Console.ReadLine();
    Console.WriteLine();
    return name;
}

void startGame()
{
    int maxAttempt = 7;
    int answer = RandomNumber();
    
    string name = helloUser(maxAttempt);
    //Console.WriteLine(answer);
    for (int attempt = 1; attempt <= maxAttempt; attempt++)
    {
        int userAnswer = -1;
        while (userAnswer == -1)
        {
            userAnswer = ReadUserAnswer($"Попытка {attempt} из {maxAttempt}. Введите число от 0 до 99:");
        }
        compareAnswer(answer, userAnswer);
        Console.WriteLine();
    }
    Console.WriteLine($"Вы исчерпали все попытки, загаданное число: {answer}.");
}

startGame();








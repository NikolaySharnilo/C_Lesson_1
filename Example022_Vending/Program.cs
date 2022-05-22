using System.IO;

// AddMoney {sum} {InputCoin} - Добавляет на баланс автомата деньги; 
//при типе оплаты cash: InputCoin = {{nominal} {count}}, при типе оплаты card не используется 
// GetChange - Автомат обнуляет баланс и выдает сдачу достпуными монетами номиналом: 1, 2, 5 и 10 рублей
// BuyGood {id} {count} - Автомат выдает товар в определенном количестве и снимает деньги с баланса:
// При старте автомат сам загружается монетками, товарами и выбирается какой-то из модулей оплаты. 
//Всего есть два модуля: карта и наличка.

//Если оплата картой – то баланс зачисляется, при этом количество доступных монет не изменяется:
//Если оплата наличкой, то при добавлении баланса нужно указать какими монетами происходит оплата 
//и они добавляются в список доступных монет.
//вам так же нужно притворится, что у вас есть такой модуль выдачи товара, и, что примерно 3% заказов не выдаются. 
//Если заказ не был выдан, то деньги с баланса пользователя не снимаются.

string[] SplitText(string command)
{
    command = command.Replace("{", "");
    command = command.Replace("}", "");
    string[] text = command.Split(" ");
    return text;
}

int[,] ReadFile(string filePath)
{
    string[] lines = File.ReadAllLines(filePath);
    int[,] num = new int[lines.Length, lines[0].Split(' ').Length];
    for (int i = 0; i < lines.Length; i++)
    {
        string[] temp = lines[i].Split(' ');
        for (int j = 0; j < temp.Length; j++)
            num[i, j] = int.Parse(temp[j]);
    }
    return num;
}

void WriteFile(string filePath, int[,] array)
{
    StreamWriter sw = new StreamWriter(filePath, false);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            string spliter = " ";
            if (j == array.GetLength(1) - 1)
            {
                spliter = "";
            }
            sw.Write($"{array[i, j]}{spliter}");
        }
        if (i < array.GetLength(0) - 1)
        {
            sw.WriteLine();
        }

    }
    sw.Close();

}

void PrintArray(string[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray_2(string[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"{arr[i]} ");

        Console.WriteLine();
    }
}

void resetData()
{
    int[,] balans = new int[,] { { 0 } };
    int[,] coinsBalans = new int[,] { { 1, 100 }, { 2, 100 }, { 5, 100 }, { 10, 100 } };
    int[,] goods = new int[,] { { 1, 5, 50 }, { 2, 5, 55 }, { 3, 5, 80 }, { 4, 5, 80 } };

    string filePathBalans = $"{Environment.CurrentDirectory}/balans.txt"; // путь к файлу balans.txt храниться текущий баланс пользователя
    string filePathCoinsBalans = $"{Environment.CurrentDirectory}/coinsBalans.txt"; // путь к файлу coinsBalans.txt храниться массив с номиналом и количеством монет в терминале 
    string filePathGoods = $"{Environment.CurrentDirectory}/goods.txt"; // путь к файлу balans.txt хранятся данные о товаре в терминале

    WriteFile(filePathCoinsBalans, coinsBalans);
    WriteFile(filePathGoods, goods);
    WriteFile(filePathBalans, balans);
}

//resetData();

string command = "";

command = "AddMoney {120}";
//int[,] InputCoin = new int[,] { { 1, 1 }, { 2, 2 } };
int[,] InputCoin = new int[,] { { 0, 0 } };

//command = "BuyGood {2} {1}"; // покупка товара с номером {2} в количестве {1}

//command = "GetChange"; // выдать сдачу

VendingTerminal(command, InputCoin, "card"); //string payType = "cash"; // "card" or "cash"; // тип оплаты, задается изначально

void VendingTerminal(string command, int[,] InputCoin, string payType)
{
    //string command = Console.ReadLine();

    string filePathBalans = $"{Environment.CurrentDirectory}/balans.txt"; // путь к файлу balans.txt храниться текущий баланс пользователя
    int[,] balans = ReadFile(filePathBalans); // баланс   

    string filePathCoinsBalans = $"{Environment.CurrentDirectory}/coinsBalans.txt"; // путь к файлу coinsBalans.txt храниться массив с номиналом и количеством монет в терминале 
    int[,] coinsBalans = ReadFile(filePathCoinsBalans); // хратятся 2 столбца: номинал, количество монет    

    string filePathGoods = $"{Environment.CurrentDirectory}/goods.txt"; // путь к файлу balans.txt хранятся данные о товаре в терминале
    int[,] goods = ReadFile(filePathGoods); // хранится 3 столбца: id товара, количество товара в ячейке, цена товара

    if (command.Contains("AddMoney") == true) // если приходит команда AddMoney нужно обновить баланс, если тип оплаты cash обновить количество монет в терминале
    {
        string[] text = SplitText(command); // раскладываем команду AddMoney {sum} {nominal} {count}; nominal и count есть только если тип оплаты cash
        balans[0, 0] += int.Parse(text[1]); // переписываем баланс

        if (payType == "cash") // если тип оплаты cash тогда обрабатываем массив InputCoin и добавляем в массив принятые монеты
        {
            for (int i = 0; i < coinsBalans.GetLength(0); i++)
            {
                for (int j = 0; j < InputCoin.GetLength(0); j++)
                {
                    if (coinsBalans[i, 0] == InputCoin[j, 0])
                    {
                        coinsBalans[i, 1] += InputCoin[j, 1]; // если номинал совпал, добавлем в массив новое количество монет
                    }
                }
            }
        }
    }

    else if (command.Contains("GetChange") == true) // модуль выдачи сдачи 
    {
        int balansTerminal = 0;
        for (int i = 0; i < coinsBalans.GetLength(0); i++) //подчет общего баланса денег в терминале
        {
            balansTerminal += (coinsBalans[i, 0] * coinsBalans[i, 1]);
        }

        while (balans[0, 0] > 0)
        {
            for (int i = (coinsBalans.GetLength(0) - 1); i >= 0; i--) //проходим по массиву снизу вверх от большего номинала к меньшему
            {
                if (balansTerminal > 0)
                {
                    if (balans[0, 0] >= coinsBalans[i, 0]) //проверяем что баланс к возврату больше или равен номиналу монеты
                    {
                        int refund = balans[0, 0] / coinsBalans[i, 0]; // считаем сколько монет из текущего номинала нужно вернуть
                        if (coinsBalans[i, 1] < refund) // проверяем достаточно ли монет текущего номинала к возврату
                        {
                            refund = coinsBalans[i, 1]; // если нет то возвращаем имеющееся количество монет
                        }

                        // модуль возврата монет номинала coinsBalans[i, 0] в количестве refund
                        balans[0, 0] -= (refund * coinsBalans[i, 0]);
                        coinsBalans[i, 1] -= refund;
                        balansTerminal -= (refund * coinsBalans[i, 0]);
                    }
                }
                else
                {
                    Console.WriteLine("В терминале отсутсвуют денежные средства");
                    WriteFile(filePathCoinsBalans, coinsBalans);
                    WriteFile(filePathGoods, goods);
                    WriteFile(filePathBalans, balans);
                    Environment.Exit(0);
                }
            }
        }

    }

    else if (command.Contains("BuyGood") == true) // модуль покупки товара "BuyGood {id} {count} "
    {
        string[] text = SplitText(command);
        int id = int.Parse(text[1]);
        int countBuy = int.Parse(text[2]);

        for (int i = 0; i < goods.GetLength(0); i++)
        {
            if (goods[i, 0] == id) // ищем  Id товара в массиве goods
            {
                if (goods[i, 1] >= countBuy) // проверяем что количество товара достаточно для покупки
                {
                    if (balans[0, 0] >= (goods[i, 2] * countBuy)) // поверяем что баланс достаточен для покупки нужного количества товара
                    {
                        // модуль выдачи товара (по условию 3% выдачи товара выполняются с ошибкой)
                        bool delivery = false;
                        while (delivery == false) // повторяем попытку выдачи пока она не будет успешной
                        {
                            int a = new Random().Next(1, 101);
                            if (a > 3)
                            {
                                delivery = true;
                            }
                        }

                        if (delivery == true)
                        {
                            balans[0, 0] -= (goods[i, 2] * countBuy); // вычитаем из баланса сумму покупки
                            goods[i, 1] -= countBuy; // уменьшаем в массиве остаток товара
                        }
                    }
                    else
                    {
                        Console.WriteLine("Суммы на балансе не достаточно для оплаты покупки");
                    }
                }
                else
                {
                    Console.WriteLine("Количества товара не достаточно для покупки");
                }
            }
        }
    }

    else
    {
        Console.WriteLine("Команда не распознана");
    }

    WriteFile(filePathCoinsBalans, coinsBalans);
    WriteFile(filePathGoods, goods);
    WriteFile(filePathBalans, balans);

}


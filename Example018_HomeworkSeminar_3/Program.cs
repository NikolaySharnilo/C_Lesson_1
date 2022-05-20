// Task 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//          является ли оно палиндромом.

void CheckNumberPalindrome(int num)
{
    if (num.ToString().Length == 5)
    {
        if (num / 10000 == num % 10)
        {
            int x = num / 10000;
            x = x / 10;
            if (x / 1000 == x % 10)
            {
                Console.WriteLine($"Число {num} является полиндромом");
            }
        }
        else
        {
            Console.WriteLine($"Число {num} не является полиндромом");
        }
    }
    else
    {
        Console.WriteLine($"Число {num} не пятизначное");
    }
}

CheckNumberPalindrome(12821);
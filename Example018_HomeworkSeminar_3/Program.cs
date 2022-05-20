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

//CheckNumberPalindrome(12821);

// Task 2: Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

double FindDistance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);
}
Console.WriteLine(FindDistance3D(7,-5,0,1,-1,9));
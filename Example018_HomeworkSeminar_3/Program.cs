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
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
}
//Console.WriteLine(FindDistance3D(7,-5,0,1,-1,9));

// Task 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void CubNumberToN(int n)
{
    if (n > 0)
    {
        int i = 0;
        Console.Write($"Cub 1 to {n} -> ");
        string txt = ",";
        while (i < n)
        {
            if (i + 1 == n)
            {
                txt = "";
            }

            Console.Write($"{Math.Pow(i + 1, 3)}{txt} ");
            i++;
        }
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Введите число больше 0");
    }
    
}
CubNumberToN(5);
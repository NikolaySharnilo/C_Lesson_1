string Method4(int count, string txt)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + txt;
    }
    return result;
}

//Console.WriteLine(Method4(4, "z"));

/* for (int i=2; i<=10; i++)
{
    for (int j=1; j<=10; j++)
    {
        Console.WriteLine($"{i}x{j} = {i*j}");
    }
    Console.WriteLine();
} */

//_________ Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К"
// а большие "С" заменить маельникими "с".

string text = " - Я думаю, - сказал князь, улыбаясь, - что,  "
            + "ежеди бы вас послали вместо нашего милого Ванценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//  string s = "qwerty"
//              012..
// s[3] -> r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;

}

/* string newText = Replace(text, ' ', '-');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); */

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortMinToMax(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < count; j++)
        {
            if (array[minPosition] > array[j]) minPosition = j;
        }
        if (i != minPosition)
        {
            array[i] = array[i] + array[minPosition];
            array[minPosition] = array[i] - array[minPosition];
            array[i] = array[i] - array[minPosition];
        }

    }
}

void SortMaxToMin(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < count; j++)
        {
            if (array[maxPosition] < array[j]) maxPosition = j;
        }
        if (i != maxPosition)
        {
            array[i] = array[i] + array[maxPosition];
            array[maxPosition] = array[i] - array[maxPosition];
            array[i] = array[i] - array[maxPosition];
        }

    }
}

int[] array = { 6, 8, 3, 1, 1, 1, 2, 1, 4, 5, 7 };
PrintArray(array);
SortMinToMax(array);
PrintArray(array);
SortMaxToMin(array);
PrintArray(array);



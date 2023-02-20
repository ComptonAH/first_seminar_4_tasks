int[,] RandomFillArray()
{
    int[,] array = new int[3,3];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 7);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}

int MaxOfArray(int[,] Array)
{
    int Max = Array[0,0];
    foreach (int element in Array)
    {
        if (element > Max) Max = element;
    }
    return Max;
}

void showHowManySameDigitArrayContains(int[,] Array)
{
    int Max = MaxOfArray(Array);

    for (int countArrayElement = 0; countArrayElement <= Max; countArrayElement++)
    {
        int numberTimesCount = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                if (Array[i,j] == countArrayElement) numberTimesCount ++;
            }
        }
        Console.WriteLine($"The number {countArrayElement} repeats {numberTimesCount}");
    }
}

int[,] Array = RandomFillArray();
showHowManySameDigitArrayContains(Array);

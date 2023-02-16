double[,] MultiDimensionalArray()
{
    double[,] Array = new double[3, 4];
    return Array;
}

double[,] RandomFillArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(-10, 11);
        }
    }
    return Array;
}

void PrintArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverage(double[,] Array)
{
    double average = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            average = average + Array[i,j];
        }
        average = average / Array.GetLength(1);
        Console.Write($"{Math.Round(average,2)} ");
    }
}

double[,] Array = RandomFillArray(MultiDimensionalArray());
PrintArray(Array);
Console.WriteLine();
FindAverage(Array);
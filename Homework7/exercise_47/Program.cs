double[,] Array = new double[3, 4];
double[,] RandomFillArray(double[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().NextDouble() * 10;
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
            Console.Write($"{Math.Round(Array[i, j],2)} ");
        }
        Console.WriteLine();
    }

}

RandomFillArray(Array);
PrintArray(Array);
int[,] MultiDimensionalArray()
{
    int[,] Array = new int[3, 4];
    return Array;
}

int[,] RandomFillArray(int[,] Array)
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

void PrintArray(int[,] Array)
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

void DigitPrint(int[,] Array)
{
    Console.WriteLine("Enter a number of the row: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter a number of the column: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if (i <= Array.GetLength(0) && j <= Array.GetLength(1)) Console.WriteLine($"The number of the positions is: {Array[i,j]}");
    else Console.WriteLine("The number with specified positions doesn't exist :(");
}

int[,] Array = RandomFillArray(MultiDimensionalArray());
PrintArray(Array);
Console.WriteLine();
DigitPrint(Array);
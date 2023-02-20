int[,] RandomFillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    return array;
}


int[,] transposeArray(int[,] Array, int columns,int rows)
{
    Console.WriteLine();
    int[,] transposedArray = new int[columns, rows];
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            transposedArray[i, j] = Array[j, i];
            Console.Write($"{transposedArray[i, j]} ");
        }
        Console.WriteLine();
    }
    return transposedArray;
}

int rows = Convert.ToInt32(Console.ReadLine());
if (rows < 0) 
{
    Console.WriteLine("You have to enter a positive number. Try again");
}
else
{
    int columns = Convert.ToInt32(Console.ReadLine());
    if (columns < 0) Console.WriteLine("You have to enter a positive number. Try again");
    else transposeArray(RandomFillArray(rows,columns),columns,rows);
}
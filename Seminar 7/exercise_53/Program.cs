int[,] RandomFillArray()
{
    int[,] array = new int[4,4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-10,11);
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    return array;
}


int[,] SwapFirstLastRow(int[,] Array)
{
    int[,] swappedArray = new int[4,4];
    
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (i == Array.GetLength(0)-1 || i == 0)
        {   
            for (int j = 0, n = 0; j < Array.GetLength(1); j++,n++)
            {
                if (i == 0)
                {
                    swappedArray[i,j] = Array[Array.GetLength(0)-1,n];
                }
                else
                {
                    swappedArray[i,j] = Array[0,n];
                }
            }
        }
        else
        {
            for (int j = 0; j < Array.GetLength(1); j++) { swappedArray[i,j] = Array[i,j]; }
        }
    }
   
    Console.WriteLine();

    for (int i = 0; i < swappedArray.GetLength(0); i++)
    {
        for (int j = 0; j < swappedArray.GetLength(1); j++)
        {
            Console.Write($"{swappedArray[i,j]} ");
        }
        Console.WriteLine();
    }
    return swappedArray;
}

SwapFirstLastRow(RandomFillArray());
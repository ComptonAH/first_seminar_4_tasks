int[,] FillArray()
{
    int[,] array = new int[4,4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine($"Enter a value for the [{i},{j}] element");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

int MinOfArray(int[,] Array)
{
    int Min = Array[0,0];
    foreach (int element in Array)
    {
        if (element < Min) Min = element;
    }
    return Min;
}

int[,] deleteMinDigitRowColumn(int[,] Array, int Min)
{
    int minRow = 0;
    int minColumn = 0;

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i,j] == Min)
            {
                minRow = i;
                minColumn = j;
                break;
            }
        }
    }

    int[,] newArray = new int[Array.GetLength(0),Array.GetLength(1)];

    for (int m = 0; m < Array.GetLength(0); m++)
    {
        if (m != minRow)
        {        
            for (int n = 0; n < Array.GetLength(1); n++)
            {
                if (n != minColumn)
                {
                    newArray[m,n] = Array[m,n];
                }
            }
        }
    }
    return newArray;
}

int[,] Array = FillArray();
int Min = MinOfArray(Array);

deleteMinDigitRowColumn(Array, Min);
int[,] CreateMatrixRandomInt(int SizeX, int SizeY, int min, int max)
{
    int[,] matrix = new int[SizeX, SizeY];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(min, max + 1);
        }

    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4} ");
        }

        Console.WriteLine("|");
    }
}

int[,] RemoteMinColumsArray2D(int[,] arr2D, int indexRow, int indexColum)
{
    int rows = arr2D.GetLength(0);
    int colums = arr2D.GetLength(1);
    int[,] matrix = new int[rows - 1, colums - 1];
    int m = 0;
    for (int i = 0; i < rows - 1; i++)
    {
        int n = 0;
        if (m == indexRow) m++;
        for (int j = 0; j < colums - 1; j++)
        {
            if (n == indexColum) n++;
            matrix[i, j] = arr2D[m, n];
            n++;
        }
        m++;
    }
    return matrix;
}

void MinMaxMatrix(int[,] arr2D, out int indexRow, out int indexColum)
{
    int rows = arr2D.GetLength(0);
    int colums = arr2D.GetLength(1);
    int min = arr2D[0, 0];
    indexRow = 0;
    indexColum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            if (arr2D[i, j] < min)
            {
                min = arr2D[i, j];
                indexRow = i;
                indexColum = j;
            }
        }
    }
}

int[,] array2D = CreateMatrixRandomInt(4, 4, 1, 50);
PrintMatrix(array2D);
Console.WriteLine();
int rowIndex, columIndex;
MinMaxMatrix(array2D, out rowIndex, out columIndex);
int[,] RemArr2D = RemoteMinColumsArray2D(array2D, rowIndex, columIndex);
PrintMatrix(RemArr2D);

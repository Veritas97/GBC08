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

void ReplaceRows(int[,] arr2D)
{
    int temp = 0;
    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        temp = arr2D[0, j];
        arr2D[0, j] = arr2D[arr2D.GetLength(0) - 1, j];
        arr2D[arr2D.GetLength(0) - 1, j] = temp;
    }
}
int[,] array2D = CreateMatrixRandomInt(3, 4, 1, 10);
PrintMatrix(array2D);
ReplaceRows(array2D);
Console.WriteLine();
PrintMatrix(array2D);


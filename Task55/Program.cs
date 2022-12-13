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

int[,] CreateModMatrix(int[,] arr2D)
{
    int[,] NewArr2D = new int[arr2D.GetLength(0), arr2D.GetLength(1)];

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            NewArr2D[i,j] = arr2D[j,i];
        }
    }

    return NewArr2D;
}

int[,] array2D = CreateMatrixRandomInt(3, 4, 1, 10);
PrintMatrix(array2D);
if (array2D.GetLength(0) == array2D.GetLength(1))
{
    int[,] matrix = CreateModMatrix(array2D);
    Console.WriteLine();
    PrintMatrix(matrix);
}
else Console.Write("Замена невозможна");

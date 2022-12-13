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

int[,] SumArr2D(int[,] arr2D, int[,] arr2D1)
{
    int size = 2;
    int[,] SumArray2D = new int[size,size];

    for (int i = 0; i < size; i++)
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                SumArray2D[i, j] = SumArray2D[i, j] + (arr2D[i, k] * arr2D1[k, j]);
            }
        }
    return SumArray2D;
}

int[,] array2D = CreateMatrixRandomInt(2, 2, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[,] array2D1 = CreateMatrixRandomInt(2, 2, 1, 9);
PrintMatrix(array2D1);
Console.WriteLine();
int[,] SumArray2D = SumArr2D(array2D,array2D1);
PrintMatrix(SumArray2D);

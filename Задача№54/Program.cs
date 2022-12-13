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

void MinMaxMatrix(int[,] arr2D)
{
    int rows = arr2D.GetLength(0);
    int colums = arr2D.GetLength(1);
    for (int i = 0; i < rows; i++)
    for (int j = 0; j < colums - 1; j++)
    {
        for (int z = 0; z < colums - 1; z++)
        {
            if (arr2D[i, z] < arr2D[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
            {
                int temp = 0;
                temp = arr2D[i, z];
                arr2D[i, z] = arr2D[i, z + 1];
                arr2D[i, z + 1] = temp;
            }
        }
    }
}


int[,] array2D = CreateMatrixRandomInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
MinMaxMatrix(array2D);
PrintMatrix(array2D);
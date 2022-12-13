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

void MinSumMatrix(int[,] arr2D)
{
    int index = 0;
    int minsum = Int32.MaxValue;
    int rows = arr2D.GetLength(0);
    int colums = arr2D.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < colums; j++)
        {
            sum = sum + arr2D[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            index++;
        }
    }
    Console.WriteLine($"Cтрока с наименьшей суммой элементов: {index}, с суммой элементов равной: {minsum}");
}

int[,] array2D = CreateMatrixRandomInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
MinSumMatrix(array2D);
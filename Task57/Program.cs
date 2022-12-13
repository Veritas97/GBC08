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

int[] MatrixToArray(int[,] arr2D)
{
    int[] arr = new int[arr2D.Length];
    int k = 0;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            arr[k++] = arr2D[i, j];
        }
    }
    return arr;
}

void PrintMassiv(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }

    Console.WriteLine("]");
}

void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == num) count++;
        else
        {
            Console.WriteLine($"Число {num} встречается {count} раз");
            count = 1;
            num = arr[i];
        }
    }
    Console.WriteLine($"Число {num} встречается {count} раз");
}

int[,] array2D = CreateMatrixRandomInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] array = MatrixToArray(array2D);
Array.Sort(array);
PrintMassiv(array);
Console.WriteLine();
CountValue(array);
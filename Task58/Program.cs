// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateFirstMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] CreateSecondMatrixRndInt(int rows, int columns, int min, int max)
{
    var matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

bool DimensionalCheck(int[,] firstMatrix, int[,] secondMatrix)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        row = row + 1;
    }

    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        column = column + 1;
    }

    if (row != column)
        return false;
    else
        return true;
}

int[,] MutriplicationMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] mutriplicationMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(0)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
        {
            mutriplicationMatrix[i, j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
                mutriplicationMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
    }
    return mutriplicationMatrix;
}

Console.WriteLine("Первая матрица:");
int[,] firstArray2D = CreateFirstMatrixRndInt(4, 4, 1, 10);
PrintMatrix(firstArray2D);


Console.WriteLine("Вторая матрица:");
int[,] secondArray2D = CreateSecondMatrixRndInt(4, 4, 1, 10);
PrintMatrix(secondArray2D);


if (DimensionalCheck(firstArray2D, secondArray2D))
{
    int[,] result = MutriplicationMatrix(firstArray2D, secondArray2D);
    Console.WriteLine("Произведение двух матриц:");
    PrintMatrix(result);

}
else
    Console.WriteLine($"Невозможно найти произведение так как число строк первой матрицы не равно числу столбцов второй матрицы");




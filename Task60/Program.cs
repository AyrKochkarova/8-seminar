// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    var matrix = new int[rows, columns, depth];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k] ,4} ({i},{j},{k}) ");
            else Console.Write($"{matrix[i, j, k],4} ({i},{j},{k})");
            }
        }
        Console.WriteLine("|");
    }
}


int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 1, 100);
PrintMatrix(array3D);

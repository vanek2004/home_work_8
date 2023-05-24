// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



Console.WriteLine("- Введидите количество строк и столбцов -");
Console.Write("Колличество строк --> ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Колличество столбцов --> ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, column];
int[,] secondMatrix = new int[row, column];
int[,] newMatrix = new int[row, column];

Matrix(matrix);
PrintMatrix(matrix);

Console.WriteLine();

Matrix(secondMatrix);
PrintMatrix(secondMatrix);

int[,] newArray = NewMatrix(matrix);
PrintMatrix(newArray);

void Matrix(int[,] matrix)
{
    var random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}|");    //для симметрии
        }
        Console.WriteLine();
    }
}

int[,] NewMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1); x++)
            {
                newMatrix[i, j] = matrix[i, x] * secondMatrix[x, j];
            }
        }
    }
    return newMatrix;
}
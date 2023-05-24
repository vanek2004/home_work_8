// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("- Введидите количество строк и столбцов -");
Console.Write("Колличество строк --> ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Колличество столбцов --> ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] Array = Matrix(row, column);
PrintMatrix(Array);
Console.WriteLine();
NumMinSumRows(Array);





int[,] Matrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    var random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 10);
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
            Console.Write($"{matrix[i, j]}|");    //для симметрии
        }
        Console.WriteLine();
    }
}

void NumMinSumRows(int[,] matrix)
{
    int minRows = 0;
    int rows = 0;
    int minSumRows = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        minRows += matrix[0, i];
    }


    for (int i = 1; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
            rows += matrix[i, j];
        {
            if (rows < minRows)
            {
                minRows = rows;
                minSumRows = i;
            }
        }
        rows = 0;
    }
    Console.WriteLine($"{minSumRows + 1}");

}
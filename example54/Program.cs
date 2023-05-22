// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("- Введидите количество строк и столбцов -");
Console.Write("Колличество строк --> ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Колличество столбцов --> ");
int column = Convert.ToInt32(Console.ReadLine());


int[,] Array = Matrix(row, column);
PrintMatrix(Array);
Console.WriteLine();
OrderingRows(Array);
Console.WriteLine();
PrintMatrix(Array);


//строка    //столбцы
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

void OrderingRows(int[,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(1) - 1; x++)   // запускаем еще один цикл, для многократного прохода,
            {                                                   // пока все не отсартируется
                if (matrix[i, x] < matrix[i, x + 1])
                {
                    int temp = matrix[i, x + 1];                // сохраняем значение следующего элемента
                    matrix[i, x + 1] = matrix[i, x];            // следующему элементу приравниваем значение предыдущего 
                    matrix[i, x] = temp;                        // и меняем значения местами 
                }
            }
        }
    }
}


// 1 4 2
// 3 7 1
// 4 7 3
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)




int row = 2;
int column = 2;
int g = 2;

int[,,] newMatrix = CreateMatrix(row, column, g);
PrintMatrix(newMatrix);


int[,,] CreateMatrix(int rows, int columns, int gf)
{
    int[,,] matrix = new int[2, 2, 2];
    var random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int x = 0; x < matrix.GetLength(2); x++)
            {
                matrix[i, j, x] = random.Next(1, 10);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int x = 0; x < matrix.GetLength(2); x++)
            {
                Console.Write($"{matrix[i, j, x]} {i}{j}{x}  ");
            }
        }
    }
}
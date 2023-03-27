// Задача 51: 
// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
//[0,0_0,1_0,2_0,3] - индекс в массиве
//  1   4   7   2
//[1,0_1,1_1,2_1,3] - индекс в массиве
//  5   9   2   3
//[2,0_2,1_2,2_2,3] - индекс в массиве
//  8   4   2   4

void FillArray2D(int[,] array2D)
{
    Random rnd = new Random();
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(1, 10);
        }
    }
}

int SummDiagonalArray(int[,] array2D)
{
    int result = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (i == j)
            {
                result += array2D[i, j];
            }
        }
    }
    return result;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; //Красит вывод в указанный цвет.
            System.Console.Write(array2D[i, j] + " ");
        }

        System.Console.WriteLine();
    }
}

int rows = 3;
int columns = 4;
int[,] array2D = new int[rows, columns];

FillArray2D(array2D);
PrintArray2D(array2D);
Console.ForegroundColor = ConsoleColor.Green; //Красит вывод в указанный цвет.
System.Console.WriteLine(SummDiagonalArray(array2D));
Console.ResetColor(); // Требуется для завершения работы функции покраски.

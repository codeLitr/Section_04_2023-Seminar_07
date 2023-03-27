// Задача 49: 
// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
//[0,0_0,1_0,2_0,3] - индекс в массиве
//  1   4   7   2
//[1,0_1,1_1,2_1,3] - индекс в массиве
//  5   81  2   9
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

void SquareEvenIndexes(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        if (i % 2 == 0)
        {
            for (int j = 0; j < array2D.GetLength(1); j++)
            {
                if (j % 2 == 0)
                {
                    array2D[i, j] = (int) Math.Pow(array2D[i, j], 2);
                }
            }
        }
    }
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
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
SquareEvenIndexes(array2D);

System.Console.WriteLine();
PrintArray2D(array2D);
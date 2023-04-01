// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] CreateAndFillArray(int rows, int columns, int leftRangeValue, int rightRangeValue)
{
    int[,] array2D = new int[rows, columns];

    Random rnd = new Random();

    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = rnd.Next(leftRangeValue, rightRangeValue);
        }
    }
    return array2D;
}

void PrintArray2D(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            System.Console.Write(array2D[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine();
System.Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateAndFillArray(rows, columns, 0, 20);

System.Console.WriteLine();
PrintArray2D(array2D);
System.Console.WriteLine();
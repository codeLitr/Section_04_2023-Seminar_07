// Задача 52:
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void CalculateArithmeticMeanColumns(int[,] array2D)
{
    Console.Write("Среднее арифметическое столбца: ");
    for (int i = 0; i < array2D.GetLength(1); i++)
    {
        double sumColumns = 0;
        double arithmeticMean = 0;

        for (int j = 0; j < array2D.GetLength(0); j++)
        {
            sumColumns += array2D[j, i];
            arithmeticMean = Math.Round(sumColumns / array2D.GetLength(0), 2);
        }
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        System.Console.Write("{0}; ", string.Join("", arithmeticMean));
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

CalculateArithmeticMeanColumns(array2D);
// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] CreateAndFillArray(int rowsRnd, int columnsRnd, int leftRangeValue, int rightRangeValue)
{
    int rows = new Random().Next(1, rowsRnd + 1);
    int columns = new Random().Next(1, columnsRnd + 1);

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
            System.Console.Write(array2D[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void LetsPlayGame(int[,] array2D, int rowPos, int columnPos)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            if (rowPos < 0 || rowPos > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
            {
                Console.WriteLine("Элемент не существует  ");
            }
            else
            {
                Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
            }
            {
                System.Console.WriteLine($"Поздравляю, Вы угадали, число на данной позиции = {array2D[i, j]}");
            }
        }

    }
}

System.Console.WriteLine();
System.Console.WriteLine("Добро пожаловать в игру - Угадай, есть ли такая позиции в двумерном массиве!");
System.Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
System.Console.WriteLine();
System.Console.WriteLine("Сейчас Вам понадобится ввести диапазон, в котором будут случайным образом определены кол-во строк и столбцов.");
System.Console.WriteLine();

System.Console.Write("Введите максимальное желаемое кол-во строк: ");
int rowsRnd = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите максимальное желаемое кол-во столбцов: ");
int columnsRnd = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateAndFillArray(rowsRnd, columnsRnd, 0, 10);

System.Console.WriteLine();
System.Console.WriteLine("А теперь введите позицию в массиве. Кто знает, может Вам повезет и Вы угадаете с первого раза!");
System.Console.WriteLine();
System.Console.Write("Введите позицию строки: ");
int rowPos = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите позицию столбца: ");
int columnPos = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
PrintArray2D(array2D);
System.Console.WriteLine();

LetsPlayGame(array2D);
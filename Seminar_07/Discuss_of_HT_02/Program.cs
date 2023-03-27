// Обсуждение домашнего задания к Семинару №5:

// Задача 36:
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// МОЙ Вариант решения:

// int[] CreateAndFillArray(int size, int leftRangeValue, int rightRangeValue)
// {
//     int[] array = new int[size];

//     Random rnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//         array[i] = rnd.Next(leftRangeValue, rightRangeValue);

//     return array;
// }

// void PrintArrayInConsole(int[] array)
// {
//     Console.Write("[{0}] -> ", string.Join(", ", array));
// }

// (int evenPos, int oddPos) ShowSumNumbersInOddPositions(int[] array)
// {
//     (int evenPos, int oddPos) sumOddNumbers = (0, 0);

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             sumOddNumbers.oddPos += array[i];
//         }
//         // else
//         // {
//         //     sumOddNumbers.evenPos += 0;
//         // }
//     }
//     return sumOddNumbers;
// }

// int size = 7;
// int[] array = CreateAndFillArray(size, 0, 11);
// PrintArrayInConsole(array);
// (int evenPos, int oddPos) sumOddNumbers = ShowSumNumbersInOddPositions(array);
// System.Console.Write($"{sumOddNumbers.oddPos}");

// ВАРИАНТ решения преподавателя:

int[] InputArray (int length)
{
    int[] array = new int[length];
    Random randon = new Random();
    for (int i = 0; i<length; i++)
    {
        array[i] = randon.Next(1, 30);
    }
    return array;

}

void PrintArray (int[] array)
{
    for (int i = 0; i<=array.Length-1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int sumToArray (int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i +=2)
    {
        sum += array[i];
    }
       // int index = 1;
    // while (index < array.Length)
    // {
    //     sum = sum + array[index];
    //     index = index +2;
    // }
    return sum;
}

Console.WriteLine("Полученный массив");
int[] array = InputArray(8);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных местах в массиве - {sumToArray (array)}");
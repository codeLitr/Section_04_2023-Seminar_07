// Обсуждение домашнего задания к Семинару №5:

// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

// (int evenNumb, int oddNumb) ShowTotalNumberOfEvenNumbers(int[] array)
// {
//     (int evenNumb, int oddNumb) evenNumbers = (0, 0);

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             evenNumbers.evenNumb += 1;
//         }
//         // else
//         // {
//         //     evenNumbers.oddNumb += 0;
//         // }
//     }
//     return evenNumbers;
// }

// int size = 4;
// int[] array = CreateAndFillArray(size, 100, 1000);
// PrintArrayInConsole(array);
// (int evenNumb, int oddNumb) evenNumbers = ShowTotalNumberOfEvenNumbers(array);
// System.Console.Write($"{evenNumbers.evenNumb}");

// ВАРИАНТ решения преподавателя:

int[] InputArray (int length)
{
    int[] array = new int[length];

    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);

    }

    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i <= array.Length-1; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int findToArray (int[] array)
{
    int counter = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            counter++;
        }
    }

    return counter;
}

System.Console.WriteLine("Полученный массив");
int[] array = InputArray(8);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в массиве - {findToArray (array)}");
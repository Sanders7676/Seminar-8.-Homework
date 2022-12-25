// Задача 62

// Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



Console.WriteLine();

int[,] array = CreateRandom2DArray(4, 4);

Print2DArray(array);

Console.WriteLine();




// Метод заполнения массива по спирали

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    int[,] array = new int[countOfRows, countOfColumns];

    for (int i = 0, j = 0, number = 1; j < array.GetLength(1); j++, number++)
    {
        array[i, j] = number;
    }

    for (int j = 3, i = 1, number = 5; i < array.GetLength(0); i++, number++)
    {
        array[i, j] = number;
    }

    for (int i = 3, j = 2, number = 8; j >= 0; j--, number++)
    {
        array[i, j] = number;
    }

    for (int j = 0, i = 2, number = 11; i >= 1; i--, number++)
    {
        array[i, j] = number;
    }

    for (int i = 1, j = 1, number = 13; j < 3; j++, number++)
    {
        array[i, j] = number;
    }

    for (int i = 2, j = 2, number = 15; j >= 1; j--, number++)
    {
        array[i, j] = number;
    }

    return array;
}




// Метод печати двумерного массива

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}
// Задача 56: 

//Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.WriteLine();

int[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);

Console.WriteLine();

int RowWithLeastSumOfElements = FindRowWithLeastSumOfElements(array);

Console.WriteLine($"Строкой с наименьшей суммой элементов является {RowWithLeastSumOfElements}-я строка.");

Console.WriteLine();




// Метод нахождения номера строки с наименьшей суммой элементов в ней

int FindRowWithLeastSumOfElements(int[,] array)
{
    int[] resultArray = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        resultArray[i] = sum;
    }

    int min = resultArray[0];

    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (min > resultArray[i])
        {
            min = resultArray[i];
            index = i;
        }
    }
    
    int findRowWithLeastSumOfElements = index + 1;

    return findRowWithLeastSumOfElements;
}



// Метод генерации массива из случайных чисел

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();

    int[,] array = new int[countOfRows, countOfColumns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
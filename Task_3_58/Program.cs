// Задача 58:

// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3

// Результирующая матрица будет:
// 18 20
// 15 18




Console.WriteLine();

int[,] firstArray = CreateRandom2DArray(2, 2);

Console.WriteLine("Первый массив выглядит следующим образом:");

Print2DArray(firstArray);

Console.WriteLine();

int[,] secondArray = CreateRandom2DArray(2, 2);

Console.WriteLine("Второй массив выглядит следующим образом:");

Print2DArray(secondArray);

Console.WriteLine();

int[,] productOfTwoArrays = GetProductOfTwoArrays(firstArray, secondArray);

Console.WriteLine("Произведение первого и второго массивов выглядит следующим образом:");

Print2DArray(productOfTwoArrays);

Console.WriteLine();




// Метод нахождения произведения массивов

int[,] GetProductOfTwoArrays(int[,] firstArray, int[,] secondArray)
{
    int[,] array = new int[firstArray.GetLength(0), firstArray.GetLength(1)];

    array[0, 0] = (firstArray[0, 0] * secondArray[0, 0]) + (firstArray[0, 1] * secondArray[1, 0]);

    array[0, 1] = (firstArray[0, 0] * secondArray[0, 1]) + (firstArray[0, 1] * secondArray[1, 1]);

    array[1, 0] = (firstArray[1, 0] * secondArray[0, 0]) + (firstArray[1, 1] * secondArray[1, 0]);

    array[1, 1] = (firstArray[1, 0] * secondArray[0, 1]) + (firstArray[1, 1] * secondArray[1, 1]);

    return array;

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
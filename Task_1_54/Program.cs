// Задача 54: 

//Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



Console.WriteLine();

int[,] array = CreateRandom2DArray(3, 4);

Print2DArray(array);

Console.WriteLine();

int[,] sortedArray = SortArreyInRows(array);

Print2DArray(sortedArray);

Console.WriteLine();




// Метод генерации массива из случайных чисел

int[,] CreateRandom2DArray(int countOfRows, int countOfColumns)
{
    Random random = new Random();

    int[,] array = new int[countOfRows, countOfColumns];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}



// Метод печати двумерного массива

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}



// Метод сортировки массива

int[,] SortArreyInRows(int[,] array)
{
    int[,] arr = new int[array.GetLength(0), array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int num = array.GetLength(1) - 1;

        int min = array[i, 0];

        for (int j = 0; j < array.GetLength(1); j++)
        {
            //int min = array[i, 0];

            int index = 0;

            if (min > array[i, j])
            {
                min = array[i, j];

                index = j;

                // int temp = array[i, num];

                // array[i, num] = min;

                // array[i, index] = temp;

                for (int c = num; c >= 0; c--)
                {
                    arr[i, c] = min;
                }
            }

            // int temp = array[i, num];

            // array[i, num] = min;

            // array[i, index] = temp;
        }
       
    }
    return arr;
}


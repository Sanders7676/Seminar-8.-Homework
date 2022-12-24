// Задача 60

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.WriteLine();

int[,,] array = CreateRandom3DArray(2, 2, 2);

Print3DArray(array);

Console.WriteLine();



// Метод генерации массива из случайных чисел

int[,,] CreateRandom3DArray(int countOfRows, int countOfColumns, int countOfPage)
{
Random random = new Random();

    int[,,] array = new int[countOfRows, countOfColumns, countOfPage];

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(0, 100);
            }
        }
    }
    return array;
}


// Метод печати элементов трехмерного массива в строку

void Print3DArray(int[,,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
}




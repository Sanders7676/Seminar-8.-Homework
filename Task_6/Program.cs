// var matrix = new int[9, 5];
//     var rnd = new Random();
//  
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(12, 45);
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// Console.WriteLine();
//  
// var arr = matrix.Cast<int>().OrderByDescending(a => a).ToArray();
//  
// int c = 0;
// for (int j = 0; j < matrix.GetLength(0); j++)
// {
//     for (int k = 0; k < matrix.GetLength(1); k++)
//     {
//         matrix[j, k] = arr[c];
//         Console.Write(matrix[j, k] + " ");
//         c++;
//     }
//     Console.WriteLine();
            
// }
// Console.ReadKey();
        


//_________________________________________________________________________

var a = new Int32[4, 5];
 
            var random = new Random();
            for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
            {
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write("{0,4}", a[i, j]);
                }
            }
            //GetStatistic(a);
            Console.WriteLine("---");
            //сортируем
            for (var i = 0; i < a.GetLength(0); i++)
                //сортировка пузырьком
                for (var j = 0; j < a.GetLength(1); j++)
                    for (var k = 0; k < a.GetLength(1); k++)
                    {
                        if (a[i, j] <= a[i, k]) continue;
                        var temp = a[i, j];
                        a[i, j] = a[i, k];
                        a[i, k] = temp;
                    }
 
            for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0,4}", a[i, j]);
                }
 
 

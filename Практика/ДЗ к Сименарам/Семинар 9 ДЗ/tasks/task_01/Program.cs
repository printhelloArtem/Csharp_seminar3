// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов


        // Задаем прямоугольный двумерный массив
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Эта функция генерирует двумерный массив
        // Активировать ее в случае если нам не нужно вводить массив вручную а просто сгенерировать
//    int [,] Aray(int sizeX , int sizeY  )
//    {
//     int[,] array = new int [sizeX,sizeY];
//     Random rand  = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
        
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = rand.Next(10,100);
            
//         }
//     }
    
// return  array;
//    }



        // Находим строку с наименьшей суммой элементов
        // int minSumRowIndex = FindRowWithMinSum(matrix);

        // Выводим результат
        // Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1}");
    

    // Метод для нахождения строки с наименьшей суммой элементов
int FindRowWithMinSum(int[,] matrix)
    {
    

        int minSum = int.MaxValue;
        int minSumRowIndex = 0;

        for (int i = 0; i <matrix.GetLength(0); i++)
        {
            int currentSum = 0;

            // Считаем сумму элементов в текущей строке
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                currentSum += matrix[i, j];
            }

            // Проверяем, является ли текущая сумма минимальной
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }


// Метод для ввода размерности двумерного массива с клавиатуры пользователем
// int EnterAr( string promt)
// {
//     System.Console.WriteLine("Ведите сколько будет строк в массиве");
//     int s = Convert.ToInt32(System.Console.ReadLine());
//     System.Console.WriteLine();
//   return s;
// }

// int sizeX = EnterAr ("Введите количество строк в массиве:");
// int sizeY = EnterAr("Введите количество столбцов в массиве:");

// int[,] genAr = Aray(sizeX,sizeY);
int minSumRowIndex = FindRowWithMinSum(matrix);
System.Console.WriteLine( $"Строка под индексом - [{minSumRowIndex}]  является с наименьшей суммой элементов" );
// PrintAr(minSumRowIndex);


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных 
// и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] GenerateArray(int sizeArray, int leftRange, int rightRange)
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return newArray;
}

void PrintArray(int[] arrayForPrint)
{
    for (int i = 0; i < arrayForPrint.Length; i++)
    {
        System.Console.Write(arrayForPrint[i] + " ");
    }
}

int[] SumsOfNegativeAndPositive(int[] array)
{
    int[] sumsNumbers = new int[2];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            sumsNumbers[0] += array[i];
        else
            sumsNumbers[1] += array[i];
    }

    return sumsNumbers;
}
// -------------------------------

int[] array = GenerateArray(10, -9, 9);
PrintArray(array);

int[] result = SumsOfNegativeAndPositive(array);

System.Console.WriteLine($"\nСумма положительных: {result[0]} \nСумма отрицательных: {result[1]}");




// // Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// // Найдите сумму отрицательных 
// // и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// // сумма отрицательных равна -20.

// int[] GenerateArray(int sizeArray, int leftRange, int rightRange)
// {
//     int[] newArray = new int[sizeArray];
//     Random rand = new Random();

//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return newArray;
// }

// void PrintArray(int[] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.Length; i++)
//     {
//         System.Console.Write(arrayForPrint[i] + " ");
//     }
// }

void PrintArray2(int[] arrayForPrint) // void 
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}
// void SumsOfNegativeAndPositive(int[] array, out int sumPositive, out int sumNegative)
// {
//     sumNegative = 0;
//     sumPositive = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             sumPositive += array[i];
//         else
//             sumNegative += array[i];
//     }
// }

// // -------------------------------

// int[] array = GenerateArray(5, -9, 9);
// PrintArray(array);

// SumsOfNegativeAndPositive(array, out int sumP, out int sumN);

// System.Console.WriteLine($"\nСумма положительных: {sumP} \nСумма отрицательных: {sumN}");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] GenerateArray(int sizeArray, int leftRange, int rightRange) // int, string, double, double[]
// {
//     int[] newArray = new int[sizeArray];
//     Random rand = new Random();

//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return newArray;
// }

// void PrintArray(int[] arrayForPrint) // void 
// {
//     Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }

// void ChangeArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = -array[i];
// }

// // -------------------------------

// int[] array = GenerateArray(5, -9, 9);
// PrintArray(array);

// ChangeArray(array);
// PrintArray(array);

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да


using System.Reflection.Metadata;

int[] GenerateArray(int sizeArray, int leftRange, int rightRange) // int, string, double, double[]
{
    int[] newArray = new int[sizeArray];
    Random rand = new Random();

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rand.Next(leftRange, rightRange + 1);
    }

    return newArray;
}

void PrintArray(int[] arrayForPrint) // void 
{
    Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool FindElement(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == element) return true;

    return false;
}

// -------------------------------

int[] array = GenerateArray(5, -9, 9);
PrintArray(array);

int number = ReadInt("Введите искомое число: ");

if (FindElement(array, number))
{
    System.Console.WriteLine("Нашли число!");
}
else
{
    System.Console.WriteLine("Число не было найдено!");
}


// // Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// // [5, 18, 123, 6, 2] -> 1
// // [1, 2, 3, 6, 2] -> 0
// // [10, 11, 12, 13, 14] -> 5

// int[] GenerateArray(int sizeArray, int leftRange, int rightRange)
// {
//     int[] newArray = new int[sizeArray];
//     Random rand = new Random();

//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return newArray;
// }

// void PrintArray(int[] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.Length; i++)
//     {
//         System.Console.Write(arrayForPrint[i] + " ");
//     }
// }

// int checkNumber(int [] arr)
// {
//     int count = 0;
//     for(int i = 0; i<arr.Length; i++)
//     {
// using System.Linq.Expressions;

// int[] GenerateArray(int sizeArray, int leftRange, int rightRange) // int, string, double, double[]
// {
//     int[] newArray = new int[sizeArray];
//     Random rand = new Random();

//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = rand.Next(leftRange, rightRange + 1);
//     }

//     return newArray;
// }

// void PrintArray(int[] arrayForPrint) // void 
// {
//     Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
// }

// int[] MultArrayElements(int[] array)
// {
//     // int[] newArray = new int[array.Length / 2 + array.Length % 2];
//     int[] newArray = new int[(array.Length + 1) / 2];

//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         newArray[i] = array[i] * array[array.Length - 1 - i];
//     }

//     if(array.Length % 2 == 1)
//         newArray[newArray.Length - 1] = array[array.Length / 2];

//     return newArray;
// }

// // -------------------------------

// int[] array = GenerateArray(9, 0, 5);
// PrintArray(array);

// PrintArray(MultArrayElements(array));
//         if(arr[i] >= 10 && arr[i] <= 99)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// //---------------------------------------------------

// int[] array = GenerateArray(20, -100, 100);
// PrintArray(array);
// int numbers = checkNumber(array);
// Console.WriteLine(" ");
// Console.WriteLine(numbers);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21



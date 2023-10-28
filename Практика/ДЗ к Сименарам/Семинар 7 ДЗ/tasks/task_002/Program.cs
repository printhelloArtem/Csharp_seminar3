// Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на определенное число. 

// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу. Элементы матрицы должны быть выведены через символ табуляции для более читаемого вывода.

// Метод FindNumberByPosition принимает на вход сгенерированную матрицу и числа x и y - позиции элемента в матрице. 

// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 

// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 

// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. 

// Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".



// using System;

// public class Answer {
//     public static void PrintArray (int [,] matrix)
//     {
//       // Введите свое решение ниже




// public static int[,] CreateIncreasingMatrix(int n, int m, int k)
// {
//   // Введите свое решение ниже
//     int [, ] matArr = new int [n ,m];
//     Random rand = new Random();

//     for (int i = 0; i < matArr.GetLength(0); i++)

//     {
//       for (int j = 0; j < matArr.GetLength(1); j++)
//       {
//         matArr[i ,j] += k;
//       }
//     } 

//     return matArr;




using System.Collections;
using System.Globalization;

int[,] CreateIncreasingMatrix(int n, int m , int k)
    {
      // Введите свое решение ниже
        int[,] arr = new int[n, m];

          int num = 1;

        for (int i = 0; i < n; i++)
        
        {
          for (int j = 0; j < m; j++)
          {
            arr[i ,j] = num;
            num = num +k; 
          }
        } 
        
        return arr;
    }

  void PrintArray(int[, ] matrix) 
{
      // Введите свое решение ниже

   for( int i = 0; i < matrix.GetLength(0); i++)
   {
     for ( int j = 0; j < matrix.GetLength(1); j++)
   
   
   Console.Write(matrix[i,j] + "\t");
  System.Console.WriteLine();
   }
}


void PrintCheckIfError (int[,] array, int X, int Y)
{
if(X > array.GetLength(0)  && Y < array.GetLength(1))
{
  System.Console.WriteLine($"The number in {array[X, Y]} is {array}");
}
  
  else System.Console.WriteLine("There is no such index");


}


static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
{

if()
}


return 
}

int n = 3;
int m = 4;
int k = 2;
int x = 8;
int y = 3;

int [,] result = CreateIncreasingMatrix(n,m,k);
PrintArray(result);
PrintCheckIfError(FindNumberByPosition)
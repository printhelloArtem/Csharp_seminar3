// Напишите программу, которая находит сумму элементов с нечетными индексами в одномерном массиве целых чисел и выводит результат на экран.

// Программа должна иметь метод SumOddElements, который принимает массив целых чисел и возвращает сумму элементов с нечетными индексами в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Аргументы, передаваемые в метод/функцию:

using System;
using System.Dynamic;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
            int count = 0;
        for (int i = 1; i < array.Length  ; i+=2)
        {
           
                count = count + array[i];


            
        }

       
      
                   
        return count;

  
         }
         
        

             
 
      
          
         
            

        
// Введите свое решение ниже


    

    public static void PrintArray(int[] array)
    {
         // Введите свое решение ниже
         for (int i = 0; i < array.Length; i++)
         {
            
       
         System.Console.Write(array[i] +"\t");
         
         }

    }







 public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] {2,3,4,5,6,7 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

         PrintArray(array);
        int sumOdd = SumOddElements(array);
         System.Console.WriteLine();
        Console.WriteLine($"Сумма нечетных элементов:{sumOdd}");
    }
    


}
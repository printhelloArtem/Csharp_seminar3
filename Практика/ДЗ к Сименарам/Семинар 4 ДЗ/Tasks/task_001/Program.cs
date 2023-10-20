// Наишите программу, которая подсчитывает количество четных элементов в массиве целых положительных трехзначных чисел и выводит результат на экран.

// Программа должна иметь метод CountEvenElements, который принимает массив целых положительных трехзначных чисел и возвращает количество четных элементов в массиве.

// Программа должна иметь метод PrintArray, который выводит элементы массива на экран.

// При выводе элементы массива должны быть разделены символом табуляции "\t".

// Если аргументы командной строки не переданы, программа использует массив по умолчанию, который содержит следующие значения: {100, 102, 105, 166, 283, 764, 300, 499, 133}.



int SumsOfNegativeAndPositive(int[] array)
{
 
         int count = 0;
      
    for (int i = 0; i < array.Length; i++)
    {
          
        if (array[i] % 2 == 0)
        {
           count = count + 1;
        }  
        
    }
    System.Console.WriteLine();

    return count;
    
}

  


   
   void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.ForegroundColor = ConsoleColor.DarkCyan;
          Thread.Sleep(50);
        System.Console.Write( array[i] + "\t");
        System.Console.ResetColor();
    }
} 

//     // int[] d = CountEvenElements(10,100 ,999);

   
   
   
   int[] array;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 100, 120, 105, 166, 283, 764, 300, 499, 133 };
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
   
   
      System.Console.WriteLine("Массив: " + " "); 
     PrintArray(array);
     int evenCount = SumsOfNegativeAndPositive(array);
     
    System.Console.ForegroundColor = ConsoleColor.DarkGreen;

    System.Console.WriteLine($"Количество четных элементов: {evenCount}");
    System.Console.ResetColor();



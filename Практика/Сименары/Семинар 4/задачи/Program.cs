// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// _тип_данных_     _название_функции_ (_принимаемые_параметры_)
// {
//     _тело_функции_
// }


// int SumNumbers(int A)
// {
//     int sum = 0;

//     for(int i = 1; i <= A; i++)
//     {
//         sum += i;
//     }

//     return sum;
// }


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Math.Abs(Convert.ToInt32(Console.ReadLine())); 
// }

// // -----------------------------------------------

// int number = ReadInt("Введите число: ");
// System.Console.WriteLine(SumNumbers(number));


// Задача 26: Напишите программу, которая принимает на вход число и 
// выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// int ReadIntAbs(string text)
// {
//     System.Console.Write(text);
//     return Math.Abs(Convert.ToInt32(Console.ReadLine()));
// }

// int LenNumber(int value)
// {
//     int len = 0;

//     while (value > 0)
//     {
//         value /= 10;
//         len++;
//     }

//     return len;
// }

// // -------------------------------

// int number = ReadIntAbs("Введите число: ");

// Console.WriteLine(LenNumber(number));



// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


// using System.Runtime.Intrinsics.Arm;

// int ReadIntAbs(string text)
// {
//     System.Console.Write(text);
//     return Math.Abs(Convert.ToInt32(Console.ReadLine()));
// }

// int MultNumbers(int N)
// {
//     int result = 1;

//     for (int i = 2; i <= N; i++)
//     {
//         result *= i;
//     }

//     return result;
// }
// // -------------------------------

// int number = ReadIntAbs("Введите число: ");
// System.Console.WriteLine(MultNumbers(number));


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// void FillArray(int[] arrayToFill)
// {
//     Random rand = new Random();

//     for (int i = 0; i < arrayToFill.Length; i++)
//     {
//         arrayToFill[i] = rand.Next(2);
//     }
// }

// void PrintArray(int[] arrayForPrint)
// {
//     for (int i = 0; i < arrayForPrint.Length; i++)
//     {
//         System.Console.Write(arrayForPrint[i] + " ");
//     }
// }

// // -----------------------------

// int[] array = new int[8];
// FillArray(array);
// PrintArray(array);



using System.Xml.XPath;

void PrinWrite(string text1, string text2)
{
    System.Console.WriteLine(text1);
    Math.Abs(Convert.ToInt32(System.Console.ReadLine()));

     System.Console.WriteLine(text2);


    Math.Abs(Convert.ToInt32(System.Console.ReadLine()));
}




// int Sum(int a ,  int b)
// {
//     int resul = a + b;

// return resul;
// }





//  PrinWrite( "Введите число 1" ,"Введите число 2");





// System.Console.WriteLine("Введите число");
// int v = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(System.Console.ReadLine());

PrinWrite("Введитее число" ,"Введите число 2" );
//  System.Console.WriteLine(Sum(  ));
int d = a;
int n =b;
int resul = d + n;

System.Console.WriteLine( "" + resul);

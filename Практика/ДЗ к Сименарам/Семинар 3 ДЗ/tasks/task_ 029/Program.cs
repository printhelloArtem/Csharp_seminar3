﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]\


int[] GetArray(int start, int end, int size)
{
    
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
       
       
        
        array[i] = new Random().Next(start, end+1);
    }
    return array;
}

void PrintArray(int[] arr)
{
System.Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("[");
    Console.ResetColor();
    for (int i = 0; i < arr.Length; i++)

    {
System.Console.ForegroundColor = ConsoleColor.DarkMagenta;
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1)
        System.Console.Write(", ");//[5, 7, 1, 4]
    }
    System.Console.ForegroundColor = ConsoleColor.Cyan;
    System.Console.Write("]");
    Console.ResetColor();
}

System.Console.WriteLine("Задай диапазон массива от:");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай диапазон массива до:");
int userEnd = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Задай размер массива:");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetArray(userStart, userEnd, userSize);
PrintArray(userArray);
Console.ResetColor();
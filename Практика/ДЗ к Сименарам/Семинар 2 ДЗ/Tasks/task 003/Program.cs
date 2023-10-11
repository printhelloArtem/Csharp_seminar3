//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//326791123 -> 6

using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;

System.Console.WriteLine("Введите данные");
int num = Convert.ToInt32(Console.ReadLine());






while (num >999 )
{
     num /= 10;
      
}

    if(num < 100)
    {
    System.Console.WriteLine("Третьего числа нет");
    }

else 
{
     System.Console.WriteLine("" + num % 10);
}     

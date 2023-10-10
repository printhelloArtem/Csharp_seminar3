// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


System.Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number <999 && number > 99 )

{
int score = number / 10;
int score2 = score % 10;

System.Console.WriteLine("" + score2);
}
else
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
}
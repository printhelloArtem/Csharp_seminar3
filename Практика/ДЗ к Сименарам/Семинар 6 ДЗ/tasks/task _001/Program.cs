// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


System.Console.Write("Укажите количество чисел: ");
int value = int.Parse(System.Console.ReadLine());

int count = 0;

for(int i = 0; i < value; i++)
{
System.Console.Write("Введите число: ");
if(int.Parse(System.Console.ReadLine()) > 0 ) count++;
}

System.Console.WriteLine("Чисел со значением больше нуля было введено: " + count);
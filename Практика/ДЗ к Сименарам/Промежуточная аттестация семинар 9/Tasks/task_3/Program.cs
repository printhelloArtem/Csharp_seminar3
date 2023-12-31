﻿
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



System.Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(System.Console.ReadLine());



int AckermannFunc  (int m, int n)
{
    if( m == 0)
    return n + 1;
    else if (m > 0 && n == 0)
    return AckermannFunc(m - 1, 1);
    else
    return AckermannFunc( m - 1, AckermannFunc(m, n -1) );
}
int res = AckermannFunc(m,n);
System.Console.WriteLine(res);
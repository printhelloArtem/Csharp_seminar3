// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


System.Console.WriteLine("Введите значение M");
int m = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите значение N");
int n = Convert.ToInt32(System.Console.ReadLine());

// МЕТОТ С ИСПОЛЬЗОВАНИЕМ ЦИКЛА FOR

//         if(m > n)
//         {
//             int temp = m;
//             m = n;
//             n = temp;
//         }
      

// int SumNum (int m , int n)
// {
//     int sum = 0;
    
//     for (int i = m; i <= n; i++)
//     {  
//       sum += i;
//     }
// return sum;
// }

// int sumNatElnts = SumNum(m,n);
//  System.Console.WriteLine(sumNatElnts);

// МЕТОД С ИСПОЛЬЗОВАНИЕМ РЕКУРСИИ:

        if(m > n)
        {
            int temp = m;
            m = n;
            n = temp;
        }


int CalculSum(int m, int n)
{
    if (m > n)
    
      return 0;
      else
      
        return m + CalculSum(m + 1 , n);

      }


int sum = CalculSum(m ,n);
System.Console.WriteLine(sum);

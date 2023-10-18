// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int SumNumber(int a)
{

    int resault = 0;
    for (int i = a; i > 0; i/=10)

    {  
        resault  = resault + i % 10;
    }
    return resault;
}


System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(System.Console.ReadLine());

int userRes = (SumNumber(num));

System.Console.WriteLine(userRes);
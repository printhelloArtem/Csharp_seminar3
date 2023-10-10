//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите день недели: ");
int num = Convert.ToInt32(Console.ReadLine());


if(num == 1)
{
System.Console.WriteLine("Будний день");
}

else if(num == 2)
{
System.Console.WriteLine("Будний день");
}

else if(num == 3)
{
System.Console.WriteLine("Будний день");
}

else if(num == 4)
{
System.Console.WriteLine("Будний день");
}

else if(num == 5)
{
    System.Console.WriteLine("Будний день");
}


else if (num ==6 || num ==7)

{
        System.Console.WriteLine("Выходной день");
}
else
{
System.Console.WriteLine("Такого дня недели не существует");
}
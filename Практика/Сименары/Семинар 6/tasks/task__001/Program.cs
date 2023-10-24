// void PrintArray2(int[] array)
// {
//     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1); // .Next(-5, 6)
    }

    return tempArray;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Reverse(int[] array)
{
    int temp = 0;

    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

// -----------------------------------

int[] myArray = GenerateArray(5, -5, 5);
PrintArray(myArray);
Reverse(myArray);
PrintArray(myArray);


// int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

// System.Console.WriteLine(string.Join(" | ", array));

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 44 -> 101100
// 3  -> 11
// 2  -> 10

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ShowBinary(int num)
{
    if(num == 0) return;
    ShowBinary(num / 2);
    System.Console.Write(num%2);
}

// --------------------

int number = ReadInt("Введите число: ");
ShowBinary(number);
System.Console.WriteLine();
Console.WriteLine(Convert.ToString(number, 2));
Console.WriteLine("Введите число:");
 int number = Convert.ToInt32(Console.ReadLine());
Console.Write("0 1 ");
int num1 = 0;
int num2 = 1;

for (int i = 0; i < number - 2; i++)
{
    int res = num1 + num2;
    Console.Write(res + " ");
    num1 = num2;
    num2 = res;
}


// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.

int[] GenerateArray(int size, int leftRange, int rightRange)
{
    int[] tempArray = new int[size];
    Random rand = new Random();

    for (int i = 0; i < tempArray.Length; i++)
    {
        tempArray[i] = rand.Next(leftRange, rightRange + 1); // .Next(-5, 6)
    }

    return tempArray;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] Copy(int[] oldArray)
{
    int[] newArray = new int[oldArray.Length];

    for (int i = 0; i < oldArray.Length; i++)
        newArray[i] = oldArray[i];

    return newArray;    
}

// -----------------------
int[] myArray = GenerateArray(10, -5, 5);
int[] copyArray = Copy(myArray);
int[] secondCopy = myArray[..];

myArray[0] = 100;

PrintArray(myArray);
PrintArray(copyArray);
PrintArray(secondCopy);
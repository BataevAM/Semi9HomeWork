// Задача 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) 
//и возводит число A в степень B.

/*
Console.WriteLine("____________");
Console.WriteLine("Задача 25");

void ExpAB(int a, int b)
{
    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result *= a;
    }
    Console.WriteLine($"Число {a} в степени {b} равняется {result}");
}

Console.WriteLine("Введите число А: ");
int inputA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int inputB = Convert.ToInt32(Console.ReadLine());

ExpAB(inputA, inputB);
*/


// Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

/*
Console.WriteLine("____________");
Console.WriteLine("Задача 27");

Console.WriteLine("Введите число:");
int inputNumber = Convert.ToInt32(Console.ReadLine());

void DigitsSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    Console.WriteLine($"Сумма цифр в числе {inputNumber} равна {sum}");
}

DigitsSum(inputNumber);
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
//и выводит отсортированный по модулю массив.

Console.WriteLine("____________");
Console.WriteLine("Задача 29");

int[] array = new int[8];

SetArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Далее отсортированный по модулю:");
PrintArray(SortArray(array));


void SetArray(int[] currentArray)
{
Random rand = new Random();
    for (int i=0; i < currentArray.Length; i++ )
    {
    currentArray[i] = rand.Next(-9, 10);
    }             
}

void PrintArray(int[] currentArray)
{
    Console.WriteLine();
    Console.WriteLine("Вывод массива на печать:");
    for (int i=0; i < currentArray.Length; i++ )
    {
        Console.Write(currentArray[i] + "\t");
    }  
    Console.WriteLine();
}

int[] SortArray(int[] array)
{
    int maxInArray;
    for (int i = 0; i < array.Length; i++) 
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if(Math.Abs(array[i]) > Math.Abs(array[j]))
            {
                maxInArray = array[i];
                array[i] = array[j];
                array[j] = maxInArray;
            }
        }
    }
    return array;
}
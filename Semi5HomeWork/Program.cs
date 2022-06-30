// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

/*
Console.WriteLine("____________");
Console.WriteLine("Задача 34");

int[] array = new int[10];

SetArray(array);
PrintArray(array);
Console.WriteLine();
EvenNumbs(array);

void SetArray(int[] currentArray)
{
Random rand = new Random();
    for (int i=0; i < currentArray.Length; i++ )
    {
    currentArray[i] = rand.Next(100, 1000);
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

void EvenNumbs(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    Console.WriteLine($"В массиве {count} четных чисел");
}
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


/*
Console.WriteLine("____________");
Console.WriteLine("Задача 36");

int[] array = new int[10];

SetArray(array);
PrintArray(array);
Console.WriteLine();
NoEvenNumbsSum(array);

void SetArray(int[] currentArray)
{
Random rand = new Random();
    for (int i=0; i < currentArray.Length; i++ )
    {
    currentArray[i] = rand.Next(1, 10);
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

void NoEvenNumbsSum(int[] array)
{
    int i = 1;
    int sum = 0;
    
    while (i < array.Length) 
    {
        sum = sum + array[i];
        i = i + 2;
    }
    Console.WriteLine($"Сумма чисел на нечетных похициях = {sum}");
}
*/


// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("____________");
Console.WriteLine("Задача 38");
Console.WriteLine();

double[] array = new double[10];

SetArray(array);
Console.WriteLine();
Console.WriteLine();
Difference(array);
Console.WriteLine();


void SetArray(double[] currentArray)
{
Random rand = new Random();
Console.WriteLine("Вывод массива на печать:");
    for (int i=0; i < currentArray.Length; i++ )
    {
    currentArray[i] = rand.NextDouble() * 100 -50;
    Console.Write("{0,6:F2}    ", currentArray[i]);
    }             
}

void Difference(double[] array)
{
    double min;
    double max;

    if (array[0] > array[1])
    {
        min = array[1];
        max = array[0];
    }
    else
    {
        min = array[0];
        max = array[1];
    }

    for(int i = 2; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
Console.Write("Максимальное число:");
Console.WriteLine("{0,6:F2}", max);
Console.Write("Минимальное число:");
Console.WriteLine("{0,6:F2}", min);
Console.Write("Разница между ними составляет:");
Console.WriteLine("{0,6:F2}", max-min);
}



// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными 
//вещественными числами, округлёнными до одного знака.

Console.WriteLine("____________");
Console.WriteLine("Задача 47");
Console.WriteLine();

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}");
Console.WriteLine();

double[,] array = new double[m, n];

void ArrayDoubleCreate(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void PrintArray (double[,] array)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double shortNumber = Math.Round(array[i, j], 1);
        Console.Write(shortNumber + " | ");
      }
      Console.WriteLine();
  }
}

ArrayDoubleCreate(array);
PrintArray(array);
Console.WriteLine();


// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном 
//массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
Console.WriteLine("____________");
Console.WriteLine("Задача 50");
Console.WriteLine();

Console.WriteLine("Используем массив из задачи № 47.");
Console.Write("Введите координаты позиции элемента (разделённые запятой): ");

string? elementPosition = Console.ReadLine();
elementPosition = SpacesDeleting(elementPosition);
int[] position = ParsingString(elementPosition);

if(position[0] <= m 
&& position[1] <= n 
&& position[0] >= 0 
&& position[1] >= 0) 
{
  double result = array[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write("такого элемента нет.");

int[] ParsingString(string input)
{
  int countNumbs = 1;
  for (int i = 0; i < input.Length; i++)
  {
      if (input[i] == ',') countNumbs++;
  }

  int[] numbers = new int[countNumbs];
  int indexNumb = 0;
  for (int i = 0; i < input.Length; i++)
  {
    string subString = String.Empty;
    while (input[i] != ',')
    {
      subString += input[i].ToString();
      if (i >= input.Length - 1) break; i++;
    }
    numbers[indexNumb] = Convert.ToInt32(subString);
    indexNumb++;
  }
  return numbers;
}

string SpacesDeleting (string input)
{
  string output = String.Empty;
  for (int i = 0; i < input.Length; i++)
  {
    if (input[i] != ' ') 
    {
      output += input[i];
    }
  }
  return output;
}
*/

// Задача 52: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("____________");
Console.WriteLine("Задача 52");
Console.WriteLine();

Console.WriteLine("Используем массив из задачи № 47.");
Console.WriteLine();
Console.WriteLine("Преобразование в целые числа:");

int[,] arrayOfIntegers = new int[m, n];
arrayOfIntegers = СonversionToIntegers(array);
PrintArrayInt(arrayOfIntegers);

for (int i = 0; i < n; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < m; j++)
  {
    arithmeticMean += arrayOfIntegers[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / m, 1);
  Console.WriteLine($"Среднеарифметическое столбца № {i+1}: {arithmeticMean}");
}

Console.WriteLine();

int[,] СonversionToIntegers (double[,] array)
{
  int[,] arrayToConv = new int[array.GetLength(0), array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      arrayToConv[i, j] = Convert.ToInt32(array[i, j]);
    }
  }
  return arrayToConv;
}

void PrintArrayInt (int[,] arrayWhole)
{
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        Console.Write(arrayWhole[i, j] + " | ");
      }
      Console.WriteLine();
  }
}
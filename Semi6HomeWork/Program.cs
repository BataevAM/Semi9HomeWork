// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.WriteLine("____________");
Console.WriteLine("Задача 41");
Console.WriteLine();

Console.Write($"Сколько чисел будете вводить?: ");
int mNumber = Convert.ToInt32(Console.ReadLine());
int[] array = new int[mNumber];

void InputNumbers(int mNumber){
for (int i = 0; i < mNumber; i++)
  {
    Console.Write($"Введите {i+1}-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int Compare(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(mNumber);

Console.WriteLine($"Количество чисел больше нуля: {Compare(array)} ");
*/


// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double[,] Coefficient = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
  for (int i = 0; i < Coefficient.GetLength(0); i++)
  {
    Console.WriteLine($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):");
    for (int j = 0; j < Coefficient.GetLength(1); j++)
    {
      if(j==0) Console.Write("Где коэффициент k равен: ");
      else Console.Write("А коэффициент b равен: ");
      Coefficient[i, j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Сalculation(double[,] Coefficient)
{
  crossPoint[0] = (Coefficient[1,1] - Coefficient[0,1]) / (Coefficient[0,0] - Coefficient[1,0]);
  crossPoint[1] = crossPoint[0] * Coefficient[0,0] + Coefficient[0,1];
  return crossPoint;
}

void Сomparison(double[,] Coefficient)
{
  if (Coefficient[0,0] == Coefficient[1,0]
     && Coefficient[0,1] == Coefficient[1,1]) 
  {
    Console.Write("Прямые идентичны.");
  }
  else if (Coefficient[0,0] == Coefficient[1,0] 
  && Coefficient[0,1] != Coefficient[1,1]) 
  {
    Console.Write("Прямые параллельны.");
  }
  else 
  {
    Сalculation(Coefficient);
    Console.Write($"Прямые пересекаются в точке: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
Сomparison(Coefficient);



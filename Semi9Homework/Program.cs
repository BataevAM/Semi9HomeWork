// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
//числа кратные 3-ём в промежутке от M до N.

/*
Console.WriteLine("____________");
Console.WriteLine("Задача 64");
Console.WriteLine();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
PrintNumber(m, n);

void PrintNumber(int m, int n)
{
  for (int i = m; i <= n; i++)
  {
    if (i % 3 == 0) Console.Write(i + " ");
  }
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/


// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

/*
Console.WriteLine("____________");
Console.WriteLine("Задача 66");
Console.WriteLine();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int sum)
{
  sum += n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {sum} ");
    return;
  }
  PrintSumm(m, n - 1, sum);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.WriteLine("____________");
Console.WriteLine("Задача 68");
Console.WriteLine();

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int akkermanFunction = Akkerman(m, n);

Console.Write($"Функция Аккермана = {akkermanFunction} ");

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
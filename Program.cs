//  Задайте значение N. Напишите программу, которая выведет все натуральные 
//числа в промежутке от N до 1. Выполнить с помощью рекурсии.
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string GetNaturalNumberTillOne(int n)
{
  if (1 < n) 
  return n + ", " + GetNaturalNumberTillOne(n-1);
  else
  return 1.ToString();
}
int n = GetNumberFromConsole("Введите число: ");
Console.Write(GetNaturalNumberTillOne(n));
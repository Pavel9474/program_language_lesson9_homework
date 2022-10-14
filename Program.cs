// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
string GetSumNaturalNumbersInGap(int M, int N, int sum=0)
{ 
  if (M <= N)  
  return GetSumNaturalNumbersInGap(M+1, N, sum+M);
  else
  return sum.ToString();
}
int M = GetNumberFromConsole("Введите меньшее число M: ");
int N = GetNumberFromConsole("Введите большее число N: ");
Console.Write(GetSumNaturalNumbersInGap(M,N));
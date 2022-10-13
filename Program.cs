// Напишите программу вычисления функции 
//Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int GetAkkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return GetAkkerman(n - 1, 1);
    else
        return GetAkkerman(n - 1, GetAkkerman(n, m - 1));
}
Console.WriteLine(GetAkkerman(3, 2));
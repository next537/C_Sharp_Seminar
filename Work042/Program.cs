﻿//Найти сумму элементов от M до N, N и M заданы

int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(1, 5));
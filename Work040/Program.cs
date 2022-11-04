﻿Console.WriteLine("Введите количество строк:");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[n + 1, 2 * n + 1];

void FillArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        array[k, 0] = 1;
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < i + 1; j++)
        {
            array[i, j] = array[i - 1, j] + array[i - 1, j - 1];
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j]} ");
            }
            else Console.Write("  ");
        }
        Console.WriteLine();
    }
}

void ResultArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            if (array[i, j] != 0)
            {
                array[i, array.GetLength(1) / 2 + j - count] = array[i, j];
                array[i, j] = 0;
                count++;
            }
        }
    }
    array[array.GetLength(0) - 1, 0] = 1;
}

FillArray(array);
ResultArray(array);
Console.WriteLine();
WriteArray(array);
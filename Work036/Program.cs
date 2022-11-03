//Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//или сообщить, что это невозможно (в случае, если матрица не квадратная).

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ReplaceArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int[,] num = new int[array.GetLength(0), array.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                num[i, j] = array[i, j];
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = num[j, i];
            }
        }
    }
    else
    {
        Console.WriteLine("Матрица не квадратная");
    }
}

Console.WriteLine("Введите количество строк: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[i, j];

FillArray(array);
PrintArray(array);
Console.WriteLine();
ReplaceArray(array);
PrintArray(array);
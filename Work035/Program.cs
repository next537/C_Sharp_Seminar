//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void ArrangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int t = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = t;
                }
            }
        }
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
ArrangeArray(array);
PrintArray(array);
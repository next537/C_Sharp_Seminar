//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадрат

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] = array[i, j] * array[i, j];
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
ReplaceArray(array);
PrintArray(array);
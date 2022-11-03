//В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int SumArray(int[,] array)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == 0)
            {
                sum += array[i, j];
                minSum += array[i, j];
            }
            else
                sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}

Console.WriteLine("Введите количество строк: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[i, j];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Строка с наименьшей суммой элементов: " + SumArray(array));
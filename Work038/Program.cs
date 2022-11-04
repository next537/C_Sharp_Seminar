//Найти произведение двух матриц

void FillArray(int[,] array, int[,] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array, int[,] array2)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write($"{array2[i, j]} ");
        }
        Console.WriteLine();
    }
}

void СompositionArray(int[,] array, int[,] array2, int[,] array3)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array3[i, j] = array[i, j] * array2[i, j];
        }
        Console.WriteLine();
    }
}

void PrintСompositionArray(int[,] array3)
{
    for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            Console.Write($"{array3[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int j = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[i, j];
int[,] matrix2 = new int[i, j];
int[,] compositionMatrix = new int[i, j];


FillArray(matrix, matrix2);
PrintArray(matrix, matrix2);
СompositionArray(matrix, matrix2, compositionMatrix);
PrintСompositionArray(compositionMatrix);
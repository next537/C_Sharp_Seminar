int sumPlus = 0;
int sumMinus = 0;
int[] array = new int[12];
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
        if (array[i] >= 0) sumPlus = array[i] + sumPlus;
        else sumMinus = array[i] + sumMinus;
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
FillArray(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Сумма положительных элементов массива равна {sumPlus}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumMinus}");
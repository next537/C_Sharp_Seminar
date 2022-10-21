int[] array = new int[10];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 50);
    Console.Write(array[i] + " ");
}

for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) count = count + array[j];
}

Console.WriteLine();
Console.Write("Сумма чисел на нечетных позициях = ");
Console.Write(count);
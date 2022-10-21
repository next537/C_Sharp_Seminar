int[] array = { 1, 3, 10, 15, 30, 40, 20, 8, 5, 2 };
int min = array[0];
int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine();
Console.Write("Разница между max и min = ");
Console.Write(max - min);
int[] array = new int[12];
int a = 0;
int b = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) a = a + 1;
    else b = b + 1;
}

Console.Write("Нечетных чисел в массиве: " + b);
Console.WriteLine();
Console.Write("Четных чисел в массиве: " + a);


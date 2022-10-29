//Написать программу копирования массива

int[] array = new int[5];
int arrayCopy;

Console.Write("Массив изначальный - ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.Write("Результат копирования - ");
for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write(arrayCopy + " ");
}
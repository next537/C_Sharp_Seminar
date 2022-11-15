//Показать натуральные числа от M до N, N и M заданы

void PrintNumber(int m, int n)
{
    if (n < m) return;
    PrintNumber(m, n - 1);
    Console.Write(n + " ");
}

Console.WriteLine("Введите число M ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine() ?? "0");

PrintNumber(m, n);
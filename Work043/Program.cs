//Написать программу вычисления функции Аккермана
int Akker(int m, int n)
{
    if (m > 6 || n > 6 || m < 0 || n < 0) return -1;

    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return Akker(m - 1, Akker(m, n - 1));
    }
}

Console.WriteLine("Введите число M ");
int m = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число N ");
int n = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine(Akker(m, n));
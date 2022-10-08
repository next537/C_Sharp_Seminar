int a = 1;

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

for (int n = a; n <= b; n = n + 1)
{
    if (n % 2 == 0)
    {
        Console.Write(n + " ");
    }
}
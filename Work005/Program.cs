Console.WriteLine("Введите число а");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("числовой ряд:");
int b = (a * -1);
if (a > 0)
{
    while (b <= a)
    {
        Console.WriteLine(b);
        b++;
    }
}
else while (a <= b)
    {
        Console.WriteLine(a);
        a++;
    }

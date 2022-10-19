Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = 0;
if (a < 0)
{
    a = -a;
}
while (0 != a)
{
    a = a / 10;
    b++;
}
Console.WriteLine("Количество цифр в числе: " + b);

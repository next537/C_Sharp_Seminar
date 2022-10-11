Console.WriteLine("Введите четверть:");
int x = int.Parse(Console.ReadLine() ?? "0");

if (x == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
else if (x == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}
else if (x == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}
else if (x == 4)
{
    Console.WriteLine("x > 0 и y < 0");
}
else
{
    Console.WriteLine("Нет такой четверти");
}
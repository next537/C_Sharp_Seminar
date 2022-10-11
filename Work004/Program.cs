Console.Write("Введите число ");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a % 2 == 1)
{
    Console.WriteLine("Число нечётное");
}
else
{
    Console.WriteLine("Число чётное");
}
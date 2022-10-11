Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}

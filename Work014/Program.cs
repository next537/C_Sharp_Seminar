Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine() ?? "0");

if ((a * a == b) || (b * b == a))
{
    Console.WriteLine("Одно из чисел является квадратом другого");
}
else
{
    Console.WriteLine("Числа не являются квадратом другого числа");
}
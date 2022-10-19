Console.WriteLine("Введите число: ");
double x = double.Parse(Console.ReadLine() ?? "0");
int count = 1;
double y = 1;
while (count <= x)
{
    double res = Math.Pow(y, 3);
    if (res % 2 == 0)
        Console.WriteLine($"{res} является кубом {y}");
    y++;
    count++;
}

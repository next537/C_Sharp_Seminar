Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int a = 1;
while (a <= n)
{
    Console.WriteLine("Произведение чисел = " + a * a);
    a++;
}

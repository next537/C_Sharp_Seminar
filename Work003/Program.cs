Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число b ");
int b = int.Parse(Console.ReadLine());

Console.Write("Введите число c ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a < b && c < b)
{
    Console.WriteLine("Максимальное число = " + b);
}
else if (a < c && a < b)
{
    Console.WriteLine("Максимальное число = " + c);
}
else if (c < a && b < a)
{
    Console.WriteLine("Максимальное число = " + a);
}
else
{
    Console.WriteLine("эти числа равны");
}
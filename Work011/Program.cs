Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine());

int c = a % b;

if (a % b == 0)
{
    Console.WriteLine("Число кратное");
}
else
{
    Console.WriteLine("Число не кратное");
    Console.WriteLine("Остаток " + c);
}
Console.WriteLine("Введите трёхзначное число ");
int a = int.Parse(Console.ReadLine());

if (a / 100 == 0)
{
    Console.WriteLine("Введенное число " + a);
    Console.WriteLine("Третьего числа нет");
}
else
{
    Console.WriteLine("Введенное число " + a);
    Console.WriteLine("Третья цифра " + a % 10);
}
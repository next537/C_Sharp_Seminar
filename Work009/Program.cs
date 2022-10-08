int a = new Random().Next(10, 99);
int b = a / 10;
int c = a % 10;

Console.WriteLine("Число из отрезка: " + a);
if (b > c)
{
    Console.WriteLine("Наибольшая цифра: " + b);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + c);
}
if (b == c)
{
    Console.WriteLine("Цифры равны");
}
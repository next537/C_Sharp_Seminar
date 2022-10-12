Console.Write("Введите пятизначное число ");
int a = int.Parse(Console.ReadLine() ?? "0");

int b = a / 10000;
int c = (a / 1000) % 10;
int d = (a / 10) % 10;
int e = a % 10;

if (b == e && c == d)
{
    Console.WriteLine("Число " + a + " является палиндромом");
}
else
{
    Console.WriteLine("Число " + a + " не является палиндромом");
}
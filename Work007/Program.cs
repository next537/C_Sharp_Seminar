Console.WriteLine("Введите трёхзначное число");
int a = int.Parse(Console.ReadLine() ?? "0");
int y = a % 10;
Console.WriteLine("Последняя цифра " + y);

Console.WriteLine("Введите трёхзначное число ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a / 10;
int y = b % 10;
Console.WriteLine("Вторая цифра = " + y);

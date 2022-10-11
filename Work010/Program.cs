Console.WriteLine("Введите трёхзначное число ");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = a / 100;
int y = a % 10;
Console.WriteLine("Вторая цифра = " + a);
Console.WriteLine("Итоговое число = " + b + y);
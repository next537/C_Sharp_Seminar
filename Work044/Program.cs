/*Написать программу показывающие первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем*/

int N = 10;
Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine() ?? "0");

int Sum(int x, int y, int num)
{
    if (num == 1) return x;
    if (num == 2) return y;
    return Sum(x, y, num - 1) + Sum(x, y, num - 2);
}
for (int i = 1; i < N; i++)
{
    Console.Write(Sum(a, b, i) + " ");
}


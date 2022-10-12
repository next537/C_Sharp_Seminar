Console.WriteLine("Введите день недели: ");
int day = int.Parse(Console.ReadLine() ?? "0");

if ((day == 6) || (day == 7))
    Console.WriteLine("Этот день недели выходной");
else
    Console.WriteLine("Этот день недели будни");

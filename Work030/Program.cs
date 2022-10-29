// Написать программу масштабирования фигуры

// (0,0) (2,0) (2,2) (0,2) 

string Scale(double x1, double y1,
                double x2, double y2,
                double x3, double y3,
                double x4, double y4,
                double n)
{
    x1 = x1 * n;
    y1 = x1 * n;
    x2 = x2 * n;
    y2 = y2 * n;
    x3 = x3 * n;
    y3 = y3 * n;
    x4 = x4 * n;
    y4 = y4 * n;
    return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
}

Console.WriteLine(Scale(0, 0, 2, 0, 2, 2, 0, 2, 2));
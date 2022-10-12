double space2D(int xa, int ya, int xb, int yb)
{
    return Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
}
Console.WriteLine(space2D(10, 10, 6, 7));

double space3D(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2));
}
Console.WriteLine(space3D(10, 9, 7, 6, 12, 12));
//21) Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09; A (7,-5); B (1,-1) -> 7,21;

void DotCoordinates2d(int[] coordinates)
{
    Console.WriteLine($"введите координаты точки: ");
    Console.Write("x = ");
    coordinates[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    coordinates[1] = Convert.ToInt32(Console.ReadLine());
}
double DistanceBetweenDots2d(int[] a,int[] b)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow((b[0]-a[0]),2) + Math.Pow((b[1]-a[1]),2)), 2);
    return distance;
}

int[] a = new int[2];
int[] b = new int[2];
Console.Write("Зададим точку А, ");
DotCoordinates2d(a);
Console.Write("Зададим точку B, ");
DotCoordinates2d(b);
Console.WriteLine();
Console.WriteLine($"A({a[0]},{a[1]}), B({b[0]},{b[1]})");
double dist = DistanceBetweenDots2d(a,b);
Console.WriteLine($"Расстояние между точками A и B = {dist}");



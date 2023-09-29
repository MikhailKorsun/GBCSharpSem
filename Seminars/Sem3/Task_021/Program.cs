// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int[] a = new int[3];
int[] b = new int[3];

void DotCoordinates3d(int[] coordinates)
{
    Console.WriteLine($"введите координаты точки: ");
    Console.Write("x = ");
    coordinates[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("y = ");
    coordinates[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("z = ");
    coordinates[2] = Convert.ToInt32(Console.ReadLine());
}
double DistanceBetweenDots3d(int[] a,int[] b)
{
    double distance = Math.Round(Math.Sqrt(Math.Pow((b[0]-a[0]),2) + Math.Pow((b[1]-a[1]),2) + Math.Pow((b[2]-a[2]),2)), 2);
    return distance;
}

Console.Write("Зададим точку А, ");
DotCoordinates3d(a);
Console.Write("Зададим точку B, ");
DotCoordinates3d(b);
Console.WriteLine();
Console.WriteLine($"A({a[0]},{a[1]},{a[2]}), B({b[0]},{b[1]},{b[2]})");
double dist = DistanceBetweenDots3d(a, b);
Console.WriteLine($"Расстояние между точками A и B = {dist}");
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


// //using System;

// public class Answer
// {
//     private static double DistanceBetweenPoints(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
//       double result = Math.Round(Math.Sqrt(Math.Pow((pointB[0]-pointA[0]),2) + Math.Pow((pointB[1]-pointA[1]),2) + Math.Pow((pointB[2]-pointA[2]),2)), 2);
//     return result;

//     }

//   // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 7;
//             x2 = -5;
//             x3 = 0;
//             y1 = 1;
//             y2 = -1;
//             y3 = 9;
//         }

//         // Не удаляйте строки ниже
//         double result = DistanceBetweenPoints(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// }
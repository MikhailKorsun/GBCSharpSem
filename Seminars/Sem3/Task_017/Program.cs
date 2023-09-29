// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


void WhatsQ(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("Число лежит на оси координат");
    else
    {
        if (x > 0)
            Console.WriteLine(y > 0? "1 четверть":"4 четверть");
        if (x < 0)
            Console.WriteLine(y > 0? "2 четверть":"3 четверть");
    }
}

Console.WriteLine("Введите координаты точки: ");
Console.Write("x = ");
int xxx = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yyy = Convert.ToInt32(Console.ReadLine());
WhatsQ(xxx, yyy);
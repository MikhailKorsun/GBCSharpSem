// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


void FindCooedinates(int quarter)
{
switch (quarter)
{
    case 1:
        Console.WriteLine("X > 0, Y > 0 ");
        break;
    case 2:
        Console.WriteLine("X < 0, Y > 0 ");
        break;
    case 3:
        Console.WriteLine("X < 0, Y < 0 ");
        break;
    case 4:
        Console.WriteLine("X > 0, Y < 0 ");
        break;
    default:
        Console.WriteLine("Введено число, которое не соответсвует номеру четверти декардовых координат. Используйте числа 1, 2, 3 или 4");
        break;
}
}

Console.Write("Введите  номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());
FindCooedinates(quarter);
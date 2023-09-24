// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void WeekEndCheck(int dayNumber)
{
    if (dayNumber >= 1 && dayNumber <=7)
    {
        if (dayNumber > 5) 
            Console.WriteLine("Выходной");
        else 
            Console.WriteLine("Будний день");
    }
    else Console.WriteLine("Число не соответствует дню недели");
}

Console.Write("Введите число дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
WeekEndCheck(day);
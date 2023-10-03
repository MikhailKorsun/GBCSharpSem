// Задача 24: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

int DigitCount(int num)
{
    int count = 1;
    while(Math.Abs(num) > 10)
    {
        num = num /10;
        count++;
    }
    return count;
}
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Колличество цифр в числе {number} составляет {DigitCount(number)}");
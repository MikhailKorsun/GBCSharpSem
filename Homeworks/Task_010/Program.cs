// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int FindSecondDigit(int num)
{
    int result = (num % 100)/10;
    return result;
}

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра вашего числа: {FindSecondDigit(number)}");
}
else
    Console.WriteLine("Вы ввели не трехзначное число");
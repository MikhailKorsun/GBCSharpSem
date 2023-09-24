// Напишите программу, которая будет принимать на вход два числа
// и выводить, является ли первое число кратным второму.
// Если первое число не кратно второму числу, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

void CheckMultiplicity (int num1, int num2)
{
    if (num1 % num2 == 0)
    {
        Console.WriteLine($"{num1} кратно {num2}");
    }
    else
    {
        Console.WriteLine($"{num1} не кратно {num2}, остаток от деления: {num1 % num2}");
    }
}

Console.WriteLine("Введите два целых числа для проверки: ");
Console.Write("Первое: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

CheckMultiplicity(firstNumber,secondNumber);
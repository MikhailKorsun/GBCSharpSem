// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Palindrom(int number)
{
    if (number >= 10000 && number <= 99999)
    {
        if ((number / 10000) == (number % 10))
        {
            if ((number / 1000)-((number/10000)*10) == ((number % 100)-(number % 10))/10)
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом"); 
        }
        else
            Console.WriteLine("Число не является палиндромом");
    }
    else
        Console.WriteLine("Вы ввели неподходящее число для проверки");
}
Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
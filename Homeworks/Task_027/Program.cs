// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

int DigitSum(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

System.Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма всех цифр = {DigitSum(num1)}");
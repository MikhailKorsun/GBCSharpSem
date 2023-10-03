// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B.

int ExponentiationAToB(int a, int b) 
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}
System.Console.Write("Введите число А для возведения в степень: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число B (в какую степень возводим): ");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"{num1}^{num2} = {ExponentiationAToB(num1, num2)}");
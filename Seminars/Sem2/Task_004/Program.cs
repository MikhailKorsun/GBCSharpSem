//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int DeleteSecondDigit(int number)
{
    int ed = number % 10;
    int hundred = number / 100;
    int result = hundred * 10 + ed;
    return result;
}

int num = new Random().Next(100,1000);
Console.Write($"Сгенерированное число: {num}, новое число: ");
Console.WriteLine(DeleteSecondDigit(num));
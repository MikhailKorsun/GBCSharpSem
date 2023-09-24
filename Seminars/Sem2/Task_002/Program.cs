// Напишите программу, которая выводит 
// случайное число из отрезка [10, 99] и показывает 
// наибольшую цифру числа

int FindBiggestDigit (int num)
{
    int ed = num % 10;
    int dec = num / 10;
    if (ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }
}


int num = new Random().Next(10,100);
Console.Write($"Сгенерированное число: {num}, а его наибольшая цифра ");
Console.WriteLine(FindBiggestDigit(num));
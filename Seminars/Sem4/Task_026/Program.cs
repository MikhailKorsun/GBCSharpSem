// Задача 26: Напишите программу, которая 
// принимает на вход число (А) и выдаёт сумму чисел 
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Summ(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

System.Console.Write("Введите число для подсчета суммы от единицы до заданного: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел от 1 до {number} = {Summ(number)}");
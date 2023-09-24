// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

void CheckMultiplicityto7and23(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
        Console.WriteLine("Число {0} одновременно кратно и 7, и 23)", number);
    else
        Console.WriteLine("Число {0} некратно одновременно 7 и 23)", number);
}

Console.Write("Введите целое число: ");
int numberBeingChecked = Convert.ToInt32(Console.ReadLine());
CheckMultiplicityto7and23(numberBeingChecked);

// Либо сделать через bool
// bool CheckMultiplicityto7and23(int num)
// {
//     if (num % 7 == 0 && num % 23 ==0)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }
//
// Console.Write("Введите целое число: ");
// int numberBeingChecked = Convert.ToInt32(Console.ReadLine());
//
//bool result = CheckMultiplicityto7and23(numberBeingChecked);
//Console.WriteLine(result);
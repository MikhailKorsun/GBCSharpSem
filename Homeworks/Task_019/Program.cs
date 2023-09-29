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



// using System;

// public class Answer
// {
//     static bool IsPalindrome(int number){
//       // Введите свое решение ниже
//       if (number >= 10000 && number <= 99999)
//     {
//         if ((number / 10000) == (number % 10))
//         {
//             if ((number / 1000)-((number/10000)*10) == ((number % 100)-(number % 10))/10)
//                 return true;
//             else
//                 return false;
//         }
//         else
//             return false;
//     }
//     else
//     {
//         Console.WriteLine("Число не пятизначное");
//         return false;
//     }
//     }
  
//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 234322;
//         }

//         // Не удаляйте строки ниже
//         bool result = IsPalindrome(number);
//         System.Console.WriteLine($"{result}");
//     }
// }
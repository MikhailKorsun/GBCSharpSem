﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void TableofThird(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

Console.Write("Введите число для создания таблицы кубов: ");
int number = Convert.ToInt32(Console.ReadLine());
TableofThird(number);

// using System;

// public class Answer
// {
//    static void ShowCube(int N)
//     {
//       // Введите свое решение ниже
//       for (int i =1; i <= N; i++)
//       {
//          Console.WriteLine(Math.Pow(i,3));
//       }
//     }

//   // Не удаляйте и не меняйте метод Main! 
//       static public void Main(string[] args) {
//         int N;

//         if (args.Length >= 1) {
//             N = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             N = 5;
//         }

//         // Не удаляйте строки ниже
//         ShowCube(N);
//     }
// }
// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            count++;
        }
    }
    return count;
}
System.Console.Write("Создадим случайных массив положительных трехзначных чисел. Введите размер массива: " );
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayForTask = CreateRandomArray(size, 100, 999);
PrintArray(arrayForTask);
System.Console.WriteLine($"В данном массиве {FindEvenNumbers(arrayForTask)} четных чисел");
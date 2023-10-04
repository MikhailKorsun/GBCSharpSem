// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

int FindNumbers(int minV, int maxV, int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= minV) && (array[i] <= maxV))
        {
            
            count++;
        }
    }
    return count;
}
System.Console.Write("Input array size: " );
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: " );
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: " );
int max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
int[] arrayForTask = CreateRandomArray(size, min, max);
PrintArray(arrayForTask);
System.Console.WriteLine();
System.Console.Write("Выберем диапазон - введите нижнюю границу: ");
int minLine = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Выберем диапазон - введите верхнюю границу: ");
int maxLine = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine($"В данном масиве {FindNumbers(minLine, maxLine, arrayForTask)} чисел из диапазона [{minLine}, {maxLine}]");
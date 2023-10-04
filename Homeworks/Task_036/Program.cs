// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int FindSumOddPosition(int[] array)
{  
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        result = result + array[i];
    }
    return result;
}
System.Console.Write("Input array size: " );
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: " );
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: " );
int max = Convert.ToInt32(Console.ReadLine());

int[] arrayForTask = CreateRandomArray(size, min, max);
PrintArray(arrayForTask);
System.Console.WriteLine($"Сумма нечетных позиций = {FindSumOddPosition(arrayForTask)}");
// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

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

int[] CreateHomeArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"array[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
System.Console.WriteLine("Создадим случайный массив из 8 элементов: ");
int[] arrayForTask = CreateRandomArray(8, 0, 320000);
PrintArray(arrayForTask);
System.Console.WriteLine();
System.Console.WriteLine("Создадим массив из 8 элементов вручную");
int[] secondArray = CreateHomeArray(8);
PrintArray(secondArray);


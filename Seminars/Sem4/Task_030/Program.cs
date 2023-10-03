// Задача 30: Напишите программу, которая выводит 
// массив из 8 элементов, заполненный нулями и 
// единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

// void FillArray01(int[] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         array[i] = new Random().Next(0,2);
//     }
// }

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

// System.Console.Write("Input array size: " );
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value: " );
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value: " );
// int max = Convert.ToInt32(Console.ReadLine());

int[] arrayForTask = CreateRandomArray(8, 0, 1);
PrintArray(arrayForTask);
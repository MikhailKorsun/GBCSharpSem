// Задача 32: Напишите программу замена элементов 
// массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

// int[] CreateSetArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.WriteLine($"a[{i} = ]");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

void PrintArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
}

System.Console.Write("Input array size: " );
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: " );
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: " );
int max = Convert.ToInt32(Console.ReadLine());

int[] originArray = CreateRandomArray(size, min, max);
PrintArray(originArray);
int[] chengedArray = ChangeArray(originArray);
PrintArray(chengedArray);
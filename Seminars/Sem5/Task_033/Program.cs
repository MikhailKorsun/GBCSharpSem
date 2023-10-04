// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int[] CreateSetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"a[{i}] = ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

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
void FindNumber(int num, int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            count++;
        }
    }
    if (count > 0)
    {
        System.Console.WriteLine("Число есть в массиве");
    }
    else
    {
        System.Console.WriteLine("Числа нет в массиве");
    }
}
System.Console.Write("Input array size: " );
int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value: " );
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value: " );
// int max = Convert.ToInt32(Console.ReadLine());
//int[] arrayForTask = CreateRandomArray(size, min, max);
int[] arrayForTask = CreateSetArray(size);
PrintArray(arrayForTask);
System.Console.Write("Введите число для поиска: ");
int find = Convert.ToInt32(Console.ReadLine());
FindNumber(find, arrayForTask);

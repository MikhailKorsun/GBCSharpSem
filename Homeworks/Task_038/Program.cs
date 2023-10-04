// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomDoubleArray(int size, double minValue, double maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(minValue + (new Random().NextDouble() * (maxValue - minValue)),2);
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

double FindMaxDiff(double[] array)
{
    double result = 0;
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    return result = max - min;
}
System.Console.Write("Input array size: " );
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: " );
double min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: " );
double max = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();
double[] arrayForTask = CreateRandomDoubleArray(size, min, max);
PrintArray(arrayForTask);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным числом равна {Math.Round(FindMaxDiff(arrayForTask),2)}");

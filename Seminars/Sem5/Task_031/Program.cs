// Задача 31: Задайте массив из 12 элементов, заполненный 
// случайными числами из промежутка [-9, 9]. Найдите сумму 
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20


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

int SumPlus(int[] array)
{   
    int sumPlus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPlus = sumPlus + array[i];
        }
    }
    return sumPlus;
}
int SumMinus(int[] array)
{
    int sumMinus = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumMinus = sumMinus + array[i];
        }
    }
    return sumMinus;
}

int[] arrayForTask = CreateRandomArray(12,-9, 9);
PrintArray(arrayForTask);
System.Console.WriteLine($"положительных чисел равна {SumPlus(arrayForTask)}, сумма отрицательных равна {SumMinus(arrayForTask)}");
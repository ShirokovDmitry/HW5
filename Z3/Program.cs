// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = new double [5];
double size = array.Length;
double min = int.MaxValue;
double max = int.MinValue;
double sum = 0;
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
    sum = max - min;
}

Console.WriteLine("[{0}]", String.Join(" ", array));
Console.Write("Min {0} ", min);
Console.Write("Max {0} ", max);
Console.WriteLine();
Console.WriteLine("Cумма {0} ", sum);


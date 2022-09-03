// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] array = new int[4];
int size = array.Length;
int even = 0;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(100, 1000);
    
    if(array[i]%2 == 0)
    {
        even++;
    }
}
Console.WriteLine("[{0}]", String.Join(", ", array));
Console.WriteLine("Количество четных чисел {0} ", even);







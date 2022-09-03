//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [4];
int size = array.Length;

int notEven = 0;
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-50, 50);
}
for (int j = 1; j < size; j += 2)
{
    notEven +=array[j];
}    
Console.WriteLine("[{0}]", String.Join(",", array));
Console.WriteLine("Cумма элементов на нечётных позициях {0} ", notEven);
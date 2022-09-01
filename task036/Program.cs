// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] returnArray(int N)
{
    int[] array = new int[N];
    Console.Write("[ ");
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(-10, 10);
        Console.Write(array[i] + " ");
        
    }
    Console.WriteLine("]");
    return array;
}
Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] rndArray = returnArray(N);
int sum = 0;
for (int i = 0; i < rndArray.Length; i++)
{
    if (i % 2 == 1) sum += rndArray[i];
}
Console.WriteLine($"Сумма нечетных позиций элементов => {sum} <= ");
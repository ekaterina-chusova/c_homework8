// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void PrintArray(int[,] array) // вывод двумерного массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.WriteLine("Задайте размерность прямоугольного двумерного массива.");
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m,n];

int sum = 1;
int x = 0;
while (sum <= array.GetLength(0) * array.GetLength(1))
{
for (int j = x; j < array.GetLength(1) - x; j++)
{
    array[x,j] = sum;
    sum++;
}
for (int i = x + 1; i < array.GetLength(0) - x; i++)
{
    array[i, array.GetLength(1) - 1 - x] = sum;
    sum++;
}
for (int j = array.GetLength(1)- 2 - x; j >= x; j--)
{
    array[array.GetLength(0) - 1 - x,j] = sum;
    sum++;
}
for (int i = array.GetLength(0) - 2 - x; i > x; i--)
{
    array[i, x] = sum;
    sum++;
}
x++;
}

PrintArray(array);
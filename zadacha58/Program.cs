// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array) // заполнение двумерного массива рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 5);
        }
    }
}

void PrintArray(int[,] array) // вывод двумерного массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

Console.WriteLine("Задайте размер матриц №1");
Console.Write("Введите количество строк в матрице: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine("Задайте размер матриц №2");
Console.Write("Введите количество строк в матрице: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в матрице: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int[,] array1 = new int[m1, n1];
int[,] array2 = new int[m2, n2];

FillArray(array1);
Console.WriteLine($"Матрица №1:");
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
Console.WriteLine($"Матрица №2:");
PrintArray(array2);

int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];

if (n1 == m2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            result[i,j] = sum;
        }
    }
}
else Console.WriteLine("Невозможно перемножить матрицы, количество столбцов в первой матрице должно совпадать с количеством строк во второй матрице");

Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PrintArray(result);

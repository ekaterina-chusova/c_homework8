// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] array) // заполнение двумерного массива рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array) // вывод двумерного массива в консоль
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SotrRow(int[] array) // сортировка одномерного массива по убыванию
{
    int max = array[0];
    for (int i = 0; i < array.Length-1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                max = array[j];
                array[j] = array[i];
                array[i] = max;
            }
        }
    }
}

Console.WriteLine("Задайте размерность массива.");
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m,n];

FillArray(arr);
PrintArray(arr);

for (int i = 0; i < arr.GetLength(0); i++)
{
    int[] row = new int[arr.GetLength(1)]; 
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        row[j] = arr [i,j]; // запись каждой строки в одномерный массив
    }
    SotrRow(row);
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr [i,j] = row[j]; // возвращение отсортированной строки в двумерный массив
    }
}

Console.WriteLine();
PrintArray(arr);
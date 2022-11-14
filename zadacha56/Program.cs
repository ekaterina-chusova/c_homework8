// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, к
// оторая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array) // заполнение двумерного массива рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
Console.WriteLine("Задайте размерность прямоугольного двумерного массива.");
Console.Write("Введите количество строк в массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m, n];

FillArray(arr);
PrintArray(arr);

int[] sumrow = new int[arr.GetLength(0)]; // созданеи и заполнение нового массива с значениями сумм элементов построчно
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = sum + arr[i, j];
    }
    sumrow[i] = sum;
}

int min = sumrow[0];  // нахождение минимального значения
for (int i = 0; i < sumrow.Length; i++)
{
    if (sumrow[i] < min)
    {
        min = sumrow[i];
    }
}

Console.WriteLine();
// проверка и вывод в консоль всех строк с минимальной суммой всех значений
Console.WriteLine($"Номер строки с наименьшей суммой элементов, равной {min}: ");
for (int i = 0; i < sumrow.Length; i++)
{
    if (sumrow[i] == min)
    {
        Console.WriteLine($"{i + 1} строка");
    }
}


// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



void FillArray(int[,,] array) // заполнение трёхмерного массива рандомными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, j, z] = new Random().Next(0, 5);
            }
        }
    }
}

void PrintArray(int[,,] array) // вывод трёхмерного массива в консоль
{
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, z]}({i}, {j}, {z}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.WriteLine("Задайте размерность трёхмерного массива");
Console.Write("Введите x: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z: ");
int k = Convert.ToInt32(Console.ReadLine());

int[,,] arr = new int[m, n, k];

FillArray(arr);
PrintArray(arr);
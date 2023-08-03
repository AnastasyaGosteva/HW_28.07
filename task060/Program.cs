using System;
using System.Collections.Generic;
using System.Linq;

int[,,] FillPrint3DArray(int height, int length, int depth, int[] array1D)
{
    int n = 0;
    int[,,] array3D = new int[height, length, depth];
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = array1D[n];
                n++;
                Console.Write($"{array3D[i, j, k]} {i},{j},{k} " + "\t", -2);
            }
            Console.WriteLine();
        }
    }

    return array3D;
}

int[] Cread1DArray(int height, int length, int depth)
{
    var random = new Random();
    int[] array = Enumerable.Range(10, length * height * depth).OrderBy(n => random.Next()).ToArray();
    return array;
}

Console.WriteLine("Если количество ячеек в будущем 3D массиве превышает 90 (не включительно),"
                 + "заполнить массив уникальными целыми двухзначными числами не получится!");
Console.Write("Введите количество строк матрицы: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите глубину матрицы: ");
int z = Convert.ToInt32(Console.ReadLine());
if (x * y * z > 90) 
{
    Console.WriteLine("Ошибка! Уменьшите количество ячеек.");
}
else
{
    int[] array1D = Cread1DArray(x, y, z);
    int[,,] array3D = FillPrint3DArray(x, y, z, array1D);
}
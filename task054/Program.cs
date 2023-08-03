// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] TransformationLine(int[,] array)
{
    int buf;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int k = 0; k < array.GetLength(1) - i - 1; k++)
            {
                if (array[j, k] < array[j, k + 1])
                {
                    buf = array[j, k];
                    array[j, k] = array[j, k + 1];
                    array[j, k + 1] = buf;
                }
            }
        }
    }
    return array;
}

void printArray(int[,] array)
{
    // Console.Clear();
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} " + "\t", -2);
        }
        Console.WriteLine();
    }
}

static int[,] GreateArray(int line, int column)
{
    int[,] newArray = new int[line, column];
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = new Random().Next(1, 10);
    return newArray;
}

Console.Write("Введите количество строк в будущем массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в будущем массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = GreateArray(n, m);
printArray(array);
int[,] array2 = TransformationLine(array);
printArray(array2);
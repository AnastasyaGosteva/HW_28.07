int[,] MultiplicatiMatrix(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] resultingMatrix = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    int temp = 0;
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int n = 0; n < arraySecond.GetLength(1); n++)
        {
            temp = 0;
            for (int j = 0; j < arrayFirst.GetLength(1); j++)
            {
                temp += arrayFirst[i, j] * arraySecond[j, n];
            }
            resultingMatrix[i, n] = temp;
        }
    }
    return resultingMatrix;
}

void printArray(int[,] array)
{
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
Console.Write("Введите количество строк для первой матрицы: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваша первая матрица: ");
int[,] matrix1 = GreateArray(n1, m1);
printArray(matrix1);
Console.Write("Введите количество строк для второй матрицы: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для второй матрицы: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваша вторая матрица: ");
int[,] matrix2 = GreateArray(n2, m2);
printArray(matrix2);

if (m1 != n2) Console.WriteLine("Перемножить матрицы не получится!");
else
{
    int[,] resultingMatrix = MultiplicatiMatrix(matrix1, matrix2);
    Console.WriteLine("Результирующая матрица: ");
    printArray(resultingMatrix);
}
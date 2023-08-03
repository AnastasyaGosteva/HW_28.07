int SearchLineMinSumm(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length ; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    minIndex++;
    return (minIndex);
}

int[] CalculationSummLine(int[,] array)
{
    string text1 = "Сумма в ";
    string text2 = " стороке равна: ";

    int[] summ = new int[array.GetLength(0)];
    for (int j = 0; j < array.GetLength(0); j++)
    {
        summ[j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            summ[j] = summ[j] + array[j, k];
        }
        Console.WriteLine(text1 + (j+1) + text2 + summ[j]);
    }
    return summ;
}

void printArray(int[,] array)
{
    Console.Clear();
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
Console.WriteLine("Давайте сгенерируем прямоугольный массив (количество строк и стобцов должно быть разное).");
Console.Write("Введите количество строк в будущем массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в будущем массиве: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = GreateArray(n, m);
printArray(array);
int[] summLine = CalculationSummLine(array);
Console.WriteLine($"В {SearchLineMinSumm(summLine)} строке сумма элементов минимальна.");
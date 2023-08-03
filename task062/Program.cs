int[,] GreateTransformationArray(int[,] array, int n)
{
    int count = 1;
    int startX = 0;     //начало строки
    int startY = 0;     //начало столбца
    int endX = n - 1;   //конец строки
    int endY = n - 1;   //конец столбца

    while (startX <= endX && startY <= endY)
    {
        for (int i = startY; i <= endY; i++)
        {
            array[startX, i] = count++;
        }
        startX++;
        for (int i = startX; i <= endX; i++)
        {
            array[i, endY] = count++;
        }
        endY--;
        for (int i = endY; i >= startY; i--)
        {
            array[endX, i] = count++;
        }
        endX--;
        for (int i = endX; i >= startX; i--)
        {
            array[i, startY] = count++;
        }
        startY++;
    }
    return array;
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

static int[,] GreateArray(int n)
{
    int[,] newArray = new int[n, n];
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = 1;
    return newArray;
}

Console.Write("Введите количество строк и столбцов в будущем массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = GreateArray(n);
printArray(array);
int[,] transformationArray = GreateTransformationArray(array, n);
printArray(transformationArray);
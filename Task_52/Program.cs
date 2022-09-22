//Задача 52. 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int[,] Get2DArray(int row, int column, int start, int end)
{
    int[,] result = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] array)
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

double[] FindAverage(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);
    double[] result = new double[column];
    double value = 0;

    for (int j = 0; j < column; j++)
    {
        for (int i = 0; i < row; i++)
        {
            value += array[i, j];
        }
        result[j] = value / row;
        value = 0;
    }
    return result;
}

Console.Write("Укажите количество строк: ");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int arrayColumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное значение массива: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное значение массива: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
int[,] new2DArray = Get2DArray(arrayRow, arrayColumn, arrayStart, arrayEnd);
Console.WriteLine("Массив:");
Print2DArray(new2DArray);
double[] AverageArray = FindAverage(new2DArray);
Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ", AverageArray)}");
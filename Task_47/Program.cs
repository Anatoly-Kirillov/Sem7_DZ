// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
double[,] Get2DArray(int row, int column, int start, int end)
{
    double[,] result = new double[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
            result[i, j] /= 10;
        }
    }
    return result;
}
void Print2DArray(double[,] array)
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
Console.Write("Укажите количество строк: ");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int arrayColumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение массива: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение массива: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
double[,] new2DArray = Get2DArray(arrayRow, arrayColumn, arrayStart, arrayEnd);
Console.WriteLine();
Print2DArray(new2DArray);

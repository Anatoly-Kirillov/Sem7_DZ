//Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив,
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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

int[] SearchNum(int[,] array, int numberToSearch)
{
    int[] status = { -1, -1 };

    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            if (array[i, j] == numberToSearch)
            {
                status[0] = i;
                status[1] = j;
                return status;
            }
        }
    }
    return status;
}

Console.Write("Укажите количество строк: ");
int arrayRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int arrayColumn = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите минимальное значение массива: ");
int arrayStart = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите максимальное значение массива: ");
int arrayEnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите число для поиска: ");
int searchNum = Convert.ToInt32(Console.ReadLine());
int[,] new2DArray = Get2DArray(arrayRow, arrayColumn, arrayStart, arrayEnd);
Console.WriteLine();
Print2DArray(new2DArray);
int[] findNum = SearchNum(new2DArray, searchNum);
if (findNum[0] == -1 && findNum[1] == -1) Console.WriteLine($"Числа {searchNum} нет в массиве");
else Console.WriteLine($"Координаты числа {searchNum}: Строка {findNum[0]+1}, столбец {findNum[1]+1}");
/*Знакомство с языками программирования (семинары)
Урок 8. Двумерные массивы. Продолжение
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и
выдаёт номер строки с наименьшей суммой элементов: 1 строка   */

Console.WriteLine("Введите количество строк прямоугольного массива");
bool isParsevasizeRow = int.TryParse(Console.ReadLine(), out int sizeRow);

Console.WriteLine("Введите количество столбцов прямоугольного массива");
bool isParsevasizeColumn = int.TryParse(Console.ReadLine(), out int sizeColumn);

if (!isParsevasizeRow || !isParsevasizeColumn) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }
if (sizeRow == sizeColumn) { Console.WriteLine("Введенная размерность не соответствует прямоугольному массиву"); return; }

int[,] array = Generate2DArray(sizeRow, sizeColumn);
Print2DArray(array);
Console.WriteLine();

Console.WriteLine($"Индекс строки с минимальной суммой элементов: {FindMinSummElementRow(array)}");


// Метод создание двумерного массива типа int и заполнения его случайными числами 
int[,] Generate2DArray(int sizeRow, int sizeColumn)
{
    int[,] array = new int[sizeRow, sizeColumn];

    Random random = new Random();

    for (int i = 0; i < sizeRow; i++)
    {
        for (int j = 0; j < sizeColumn; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}


// Метод вывода двумерного массива в консоль
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

// Метод поиска строки с минимальной суммой элементов
int FindMinSummElementRow (int[,] array)
{
    int min = 0;
    int indexRowMin = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tmp = 0;

        for(int j = 0; j < array.GetLength(1); j++)
        {
            tmp += array[i,j]; 
        }

        if (i == 0) {min = tmp;}
        if (min > tmp) { min = tmp; indexRowMin = i; }

    }

    return indexRowMin;

}
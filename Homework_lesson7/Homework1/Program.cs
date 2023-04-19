/* Знакомство с языками программирования (семинары)
Урок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9    */
Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите количество строк");
bool isParsevasizerow = int.TryParse(Console.ReadLine(), out int sizeRow);

Console.WriteLine("Введите количество столбцов");
bool isParsesizecolumn = int.TryParse(Console.ReadLine(), out int sizeColumn);

if (!isParsevasizerow || !isParsesizecolumn) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }


double[,] array = FillingArrayToConsole(sizeRow, sizeColumn);
Console.WriteLine();
Print2DArray(array);


// Метод создания двумерного массива типа double с заданным количествам строк и столбцов и заполнением его в консоли 
double[,] FillingArrayToConsole(int sizeRow, int sizeColumn)
{
    double[,] array = new double[sizeRow, sizeColumn];

    for (int i = 0; i < sizeRow; i++)
    {
        for (int j = 0; j < sizeColumn; )
        {
            Console.WriteLine($"Введите значение элемента массива с индексами [{i}, {j}]");
            bool isParsed = double.TryParse(Console.ReadLine(), out double value);
            
            if(!isParsed) {Console.WriteLine($"Ошибка ввода элемента, повторите ввод"); continue; }

            array[i,j] = value;
            j++;
        }
    }
    return array;
}


// Метод вывода двумерного массива в консоль
void Print2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}
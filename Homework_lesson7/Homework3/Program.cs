/*Знакомство с языками программирования (семинары)
Урок 7. Двумерные массивы
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  */
Console.WriteLine("Введите размер двумерного массива");

Console.WriteLine("Введите количество строк");
bool isParsevasizerow = int.TryParse(Console.ReadLine(), out int sizeRow);

Console.WriteLine("Введите количество столбцов");
bool isParsesizecolumn = int.TryParse(Console.ReadLine(), out int sizeColumn);

if (!isParsevasizerow || !isParsesizecolumn) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }

int[,] array = Generate2DArray(sizeRow, sizeColumn);
Print2DArray(array);

PrintArray(FindArithmeticMeanColumnToArray(array));


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


// Метод поиска средне арифметического элементов в каждого столбца массива
double[] FindArithmeticMeanColumnToArray (int[,] array)
{
    double[] resultArray = new double[array.GetLength(1)];
    double result = 0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            result += array[i,j];
        }
        
        resultArray[j] = Math.Round(result / array.GetLength(1), 2);
    }

    return resultArray;

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


// Метод вывода в консоль одномерного массива
void PrintArray(double[] array)
{
    Console.WriteLine($"Среднеарифметическое столбцов: [{string.Join(", ", array)}]"); // вывод в консоль
}
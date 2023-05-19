/*Знакомство с языками программирования (семинары)
Урок 8. Двумерные массивы. Продолжение
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18          */

Console.WriteLine("Введите количество строк первой матрицы");
bool isParsesizeRowFirst = int.TryParse(Console.ReadLine(), out int sizeRowFirst);

Console.WriteLine("Введите количество столбцов первой матрицы");
bool isParsesizeColumnFirst = int.TryParse(Console.ReadLine(), out int sizeColumnFirst);

if (!isParsesizeRowFirst || !isParsesizeColumnFirst) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }

Console.WriteLine("Введите количество строк второй матрицы");
bool isParsesizeRowSecond = int.TryParse(Console.ReadLine(), out int sizeRowSecond);

Console.WriteLine("Введите количество столбцов второй матрицы");
bool isParsesizeColumnSecond = int.TryParse(Console.ReadLine(), out int sizeColumnSecond);

if (!isParsesizeRowSecond || !isParsesizeColumnSecond) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }

if (sizeRowFirst != sizeColumnSecond) { Console.WriteLine("Количество строк первой матрицы не равно количеству столбцов второй, нахождения произведения невозможно"); return; }

int[,] arrayFirst = Generate2DArray(sizeRowFirst, sizeColumnFirst);
Console.WriteLine("Первая матрица:");
Print2DArray(arrayFirst);
Console.WriteLine();

int[,] arraySecond = Generate2DArray(sizeRowSecond, sizeColumnSecond);
Console.WriteLine("Вторая матрица:");
Print2DArray(arraySecond);
Console.WriteLine();

int[,] arrayComposition = Composition2DMatrix(arrayFirst, arraySecond);
Console.WriteLine("Произведение первой и второй матрицы:");
Print2DArray(arrayComposition);


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

//Метод расчета произведения двух матриц
int[,] Composition2DMatrix (int[,] arrayFirst, int[,] arraySecond)
{

    int[,] arrayComposition = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];

    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            for (int k = 0; k < arraySecond.GetLength(0); k++)
            {
                arrayComposition[i,j] += arrayFirst[i, k] * arraySecond[k,j];
            }
        }
    }

    return arrayComposition;

}
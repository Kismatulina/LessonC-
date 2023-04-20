/*Знакомство с языками программирования (семинары)
Урок 8. Двумерные массивы. Продолжение
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07  */
int[,] array = GenerateArray(4,4);
Print2DArray(array);


// Метод формирования массива и заполнения его по спирали
int[,] GenerateArray(int sizeRow, int sizeColumn)
{
    int[,] array = new int [sizeRow, sizeColumn];
    
    int i = 0;
    int j = 0;
    int tmp = 1;
    int indexSizerow = 0;
    int indexSizeColumn = 0;

    bool strat = true;
    int status = 0; // 0 - вправо; 1 - вниз; 2 - влево; 3 - вверх;

    while(strat)
    {
        if (status == 0)
        {
            while (j < sizeColumn - indexSizeColumn)
            {
                array[i,j] = tmp;
                tmp++;
                j++;
            }       

            j = sizeColumn - indexSizeColumn - 1;
            i++;
            status = 1;

        }

        if (status == 1)
        {
            while (i < sizeRow - indexSizerow)
            {
                array[i,j] = tmp;
                tmp++;
                i++;
            }

            i = sizeRow - indexSizerow - 1;
            indexSizerow++;
            j--;
            status = 2;

        }

        if (status == 2)
        {
            while (j >= 0 + indexSizeColumn)
            {
                array[i,j] = tmp;
                tmp++;
                j--;
            }

            j = 0 + indexSizeColumn;
            indexSizeColumn++;
            i--;
            status = 3;
        }

        if (status == 3)
        {
            while (i >= 0 + indexSizerow)
            {
                array[i,j] = tmp;
                tmp++;
                i--;
            }

            i = 0 + indexSizerow;
            j++;  
            status = 0; 
        }

        if (indexSizeColumn == sizeColumn - (sizeColumn/2) || indexSizerow == sizeRow - (sizeRow/2))
        {
            strat = false;
        }

    }
    
    return array;

}


//Метод вывода двумерного массива в консоль
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
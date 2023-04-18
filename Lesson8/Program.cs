/*Знакомство с языками программирования (семинары)
Урок 8. Двумерные массивы. Продолжение*/

//Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] array = Generate2DArray(3, 4);// генерируем массив и ввыводим его на экран

Print2DArray(array);
RevesreArray(array);
Console.WriteLine();
Print2DArray(array);

int[,] Generate2DArray(int m, int n) // генерируем массив 
{

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array) //  и ввыводим его на экран
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

void RevesreArray(int[,] array)// пишем метод (обратный массив или перевернуть массив) ,
 //переложить нулевую в последнюю
{
/* 
array [0,0] распишем индексы у нуля.Будем обращаться к первому так
array [0,1]
array [0,2]
array [0,3]

array [2,0] распишем индексы у последней строки, есть закономерность 
array [2,1]
array [2,2]
array [array.GetLength(0)-1, 3] .Будем обращаться к последнему так

*/
    for (int i = 0; i < array.GetLength(1); i++)//перебераем столбцы
    {
        int tmp = array[0, i];//обращаемся к нашему массиву 0,0 толко теперь к 0,i
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tmp;
    }
}



/*Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

/*
int[,] array = Generate2DArray(3, 3);


RevesreArray(array);
Print2DArray(array);
ChangeRowsArray(array);
Console.WriteLine();
Print2DArray(array);

int[,] Generate2DArray(int m, int n)
{

    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

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

void RevesreArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tmp;
    }
}

void ChangeRowsArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            int tmp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = tmp;
        }

    }
}
*/

/*

Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Набор данных
Частотный массив
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза
1, 2, 3 4, 6, 1 2, 1, 6
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза  */

/*int[,] array = new int[m,n];
Random random = new Random(2, 8);

Print2DArray(array);

int[,] Generate2DArray(int m, int n)
{

     for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        
        }

    }
}*/
/*
int[,] array = Generate2DArray(2, 9);
PrintArray(array);
Dictionary<int, int> result = SummIndexTimes(array);
foreach (var row in result)
{
    Console.WriteLine($"key: {row.Key}  value: {row.Value}");
}
void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }

        Console.WriteLine();
    }
}

int[,] Generate2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }

    return array;
}

Dictionary<int, int> SummIndexTimes(int[,] array) //сколько раз встречается элемент входных данных
{
    Dictionary<int, int> dic = new Dictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (!dic.TryAdd(array[i, j], 1))
            {
                dic[array[i, j]] += 1;
            }
        }
    }
    return dic;
}
*/
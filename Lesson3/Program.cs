﻿/*
Console.WriteLine("Введите X:"); // вывод в консоль предложения ввести x
int x = int.Parse(Console.ReadLine()); // ввод в консоль x
Console.WriteLine("Введите Y:"); // вывод в консоль предложения ввести x
int y = int.Parse(Console.ReadLine()); // ввод в консоль y
int result = GetNubmerOfQuarter(x, y); // создание переменной типа int и запись в нее результат работы метода
if (result == 0) // если результат = 0
{
    Console.Write("X и Y равны нулю. Данные введены не правильно"); // если да вывод в консоль
    return; // завершение работы
}
Console.Write("X и Y попадают в четверть "); // вывод в консоль
Console.Write(result); // вывод в консоль (в ту же строку что и предыдущая)
// Метод определения четверти в которую попадают x и y
int GetNubmerOfQuarter(int x, int y)
{
    if (x > 0 && y > 0) // если x y больше 0
{
    return 1; // если да четверть 1
}
if (x < 0 && y > 0) если x меньше 0 и y больше 0
{
    return 2;   // если да четверть 2
}
if (x < 0 && y < 0) // если x меньше 0 и y меньше 0
{
    return 3;    // если да четверть 3
}
if (x > 0 && y < 0) // если x болльше 0 и y меньше 0
{
    return 4;    // если да четверть 4
}    
return 0; // если ни одно условие не выполнилось возвращаем 0
}
*/

/*
Задача No18. Общее обсуждение
Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/*
Console.WriteLine("Введите номер четверти:"); // Вывод в консоль предложения ввеси номер четверти
int quarter = int.Parse(Console.ReadLine()); // ввод в консоль номера четверти
string result = GetXY(quarter); // создание переменной типа string и запись в нее результат метода
if (result == "0") // если результат равен строке в которой записан 0
{
    Console.Write("Номер четверти введен не правильно"); // если да вывод в консоль
    return; // заверщение работы
}
Console.Write("В четверть попадаюат: "); // вывод в консоль
Console.Write(result); // вывод в консоль в ту же строку что и выше
// метод типа string определения диапазонов x и y в зависимости от указанной четверти
string GetXY(int quarter) 
{
    if (quarter == 1) // если четверть 1
{
    return "X > 0 и Y > 0"; // возврат строки
}
if (quarter == 2) // если четверть 2
{
    return "X < 0 и Y > 0";   // возврат строки
}
if (quarter == 3) // если четверть 3
{
    return "X < 0 и Y < 0";    //возврат строки
}
if (quarter == 4) // если четверть 4
{
    return "X > 0 и Y < 0";    //возврат строки
}    
return "0"; // если ни одно условие не выполнилось, то возвращаем строки с записанным символом 0
}
*/

/*
Задача No21. Работа в группах
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
● A (3,6); B (2,1) -> 5,09
● A (7,-5); B (1,-1) -> 7,21
*/

Console.WriteLine("Введите X1:"); // вывод в консоль предложения ввести х1
int x1 = int.Parse(Console.ReadLine()); // ввод в консоль х1

Console.WriteLine("Введите Y1:");// вывод в консоль предложения ввести y1
int y1 = int.Parse(Console.ReadLine()); // ввод в консоль y1

Console.WriteLine("Введите X2:");// вывод в консоль предложения ввести x1
int x2 = int.Parse(Console.ReadLine()); // ввод в консоль x1

Console.WriteLine("Введите Y2:");// вывод в консоль предложения ввести y1
int y2 = int.Parse(Console.ReadLine()); // ввод в консоль y1

double result = GetDistance(x1, x2, y1, y2); // создание переменной типа double и запись в нее результат вызова метода

if (result == 0) // если результат равен 0
{
    Console.Write("Переменные введены не правильно"); // если да вывод в консоль
    return;
}

Console.Write("Расстояние между точками: "); // вывод в консоль
Console.Write(result); // вывод в консоль переменную в ту же строку что и выше

// Метод типа double определения дистанции между точками в 2d пространстве
double GetDistance(int x1, int x2, int y1, int y2)
{

    if (x1 == 0 & y1 == 0 & x2 == 0 & y2 == 0) // проверка что введены 0
    {
        return 0; // если да прекращаем выполнение метода
    }

    double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)); // создание переменной типа double и запись в нее результата формулы

    return L; // возврат полученного значения

}


 /*
 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
от 1 до N.
● 5 -> 1, 4, 9, 16, 25.
● 2 -> 1,4
*/
/*
Console.WriteLine("Введите N:"); // вывод в консоль предложения ввести число
int n = int.Parse(Console.ReadLine()); // ввод в консоль числа
if (n == 0) // проверка равно ли число 0
{
    Console.Write("n должно быть больше 0"); // если да то прекращаем выполнение программы
    return;
}
int[] array = new int[n]; // создаем массив типа int с размером n
int i = 1; // создаем переменную типа int и приравниваем ее к 1
while (i <= n) // цикл, пока i меньше n
{
    array[i-1] = GetSquare(i); // записываем в элемент 0 массива результат выполнения метода
    Console.WriteLine($"{i}, {array[i-1]}"); // вывод в консоль
    i++; // прибавляем к i единицу
}
// Метод возведения в степень переданного элемента
int GetSquare(int j)
{
    j = j * j;
    return j;
}
*/

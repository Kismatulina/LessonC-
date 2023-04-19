/*Знакомство с языками программирования (семинары)
Урок 5. Функции и одномерные массивы*/
/*
int[] array = GenerateArray(12); // Создание массива с заданной размерностью
PrintArray(array); // Вызов метода отображения массива в консоль. 
// Вызов методов расчета сумм положительных и отрицательных элементов массива и отображения их в консоль
Console.WriteLine($"Сумма положительных элементов равна: {CalculateSumPositiveNumber(array)}");
Console.WriteLine($"Сумма отрицательных элементов равна: {CalculateSumNegativeNumber(array)}");
//Метод создания массива и заполнения его случайными числами в диапозоне
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght]; // создание массива типа int с размерность переданной в качетсве переменной lenght
    Random random = new Random(); // создание переменной типа Random
    for (int i = 0; i< lenght; i++) // цикл от i до lenght
    {
        array[i] = random.Next(-9, 10); // запись в элемент массива равный i случайного числа
    }
    return array;
}
//Метод нахождения суммы положительных элементов массива
int CalculateSumPositiveNumber(int[] array)
{
    int sumPositive = 0; // создание переменной типа int и приравнивание ее к нулю
    for (int i = 0; i < array.Length; i++) // цикл от i до array.:ength(длина переданного массива)
    {
        if (array[i] > 0) // если элемент массива больше 0
        {
            sumPositive += array[i]; // если да то данный элемент массива прибавляем к значению переменной
        }
    }
    return sumPositive; // возврат из метода результат
}
//Метод нахождения суммы отрицательных элементов массива
int CalculateSumNegativeNumber(int[] array)
{
    int sumNegative = 0; // создание переменной типа int и приравнивание ее к 0
    for (int i = 0; i < array.Length; i++) // цикл от i до array.:ength(длина переданного массива)
    {
        if (array[i] < 0) // если элемент массива меньше 0
        {
            sumNegative += array[i]; // если да то данный элемент массива прибавляем к значению переменной
        }
    }
    return sumNegative; // возврат из метода результат
}
//Метод вывода массива в консоль
void PrintArray (int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}
*/

//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
/*
int[] array = GenerateArray(6); // создание массива типа int и запись в него результат выполнения метода
PrintArray(array); // вывод в консоль массива
Revers(array); //выполнение метода изменения знака в элементах массива
PrintArray(array); // вывод массива с измененными знаками
// Метод создания массива и заполнения его случайными числами
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i< lenght; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}
// Метод вывода массива в консоль
void PrintArray (int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
// Метод изменения знаков массива
void Revers(int[] array)
{
    for (int i = 0; i < array.Length; i++) // цикл от i до array.Length (размер переданного массива)
    {
        array[i] = array[i] * (-1); // элемент массива умножаем на -1 и меняем знак
    }
    return array; // возврат из метода массива
}
*/


/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да
*/
/*
Console.WriteLine("Введите число"); // вывод в консоль предложения ввести число
int a = int.Parse(Console.ReadLine()); // ввод в консоль числа
int[] array = GenerateArray(5); // создание массива типа int и запись в него результата выполнения метода
PrintArray(array); // выполнения метода вывода массива в консоль
if (FindElement(array, a)) // если результат выполнения метода истина
{
    Console.WriteLine($"Элемент {a} найден в массиве"); // вывод в консоль
}
else // если результат выполнения метода ложь
{
    Console.WriteLine($"Элемент {a} не найден в массиве"); // вывод в консоль
}
// Метод создания массива и заполнения его случайными числами
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i < lenght; i++)
    {
        array[i] = random.Next(0, 10);
    }
    return array;
}
// Метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}
// Метод типа bool поиска заданного числа в массиве
bool FindElement(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++) // цикл от i до array.Length (длина массива)
    {
        if (array[i] == element) // если элемент массива равен заданному числу
        {
            return true; // если да возвращаем как результат метода true (истина)
        }
    }
    return false; // Если в процессе поиска в массиве не найдено заданное число то как рузультат метода возвращаем false (ложь)
}
*/

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
int[] array = GenerateArray(123); // создаем массив типа int и записываем в него результат выполнения метода
Console.WriteLine(FindeNubmers(array)); // вывод в консоль рузельтат выполнения метода
//Метод создания массива и заполнения его случайными числами
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for (int i = 0; i< lenght; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}
// Метод типа int поиска в массиве количества чисел находящихся в диапозоне от 10 до 99
int FindeNubmers(int[] array)
{
    int a = 0; // создаем переменную типа int и приравниваем ее к 0
    for (int i = 0; i < array.Length; i++) // цикл от i до array.Length (длина массива)
    {
        if (array[i] > 9 & array[i] > 100) // если элемент массива находится в диапазоне
        {
            a++; // если да то прибавляем к a единицу
        }
    }
    return a; // возвращаем результат выполнения метода
}
*/

/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

// Задаем размерность массива
Console.WriteLine("Введите размерность массива:"); // Вывод в консоль предложения ввести размерность массива
int lenght = int.Parse(Console.ReadLine()); // Вввод в консоль размерности массива

// Заполняем массив 
int[] array = GenerateArray(lenght);

//Вызываем метод вывода массива в консоль
PrintArray(array);

//Вызываем метод создания нового массива и задаем его размерность исходя из четности первого
int[] newarray = GenerateNewArray(array, array.Length/2 + lenght % 2);
PrintArray(newarray);

// Вызываем метод создания массива и его заполнение случайными числами
int[] GenerateArray(int lenght)
{
    int[] array = new int[lenght];

    Random random = new Random();

    for (int i = 0; i< lenght; i++)
    {
        array[i] = random.Next(-9, 10);
    }

    return array;
}

//Метод создания нового массива и его заполнение произведением чисел первого массива (первый и последний элемент, второй и предпоследний и т.д.)
int[] GenerateNewArray(int[] array, int lenght)
{
    int[] newarray = new int[lenght];

    for (int i = 0; i < lenght; i++)
    {
        if (array.Length % 2 == 0) // если четный
        {
            newarray[i] = array[i] * array[array.Length - i - 1]; // записываем в новый массив произведение первого и последнего элемента первого массива и т.д.
        }
        else // если не четный
        {
            if (i == (lenght - 1)) // если последний элемент массива
            {
                newarray[i] = array[i]; // последний элемент в не четном (первом) массиве не имеет пары, поэтому просто записываем его последним элементом массива (new)
            }
            else // если не последний элемент массива
            {
                newarray[i] = array[i] * array[array.Length - i - 1]; // записываем в новый массив произведение первого и последнего элемента первого массива и т.д.
            }
        }
        
    }

    return newarray;
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]");
}

/*Знакомство с языками программирования (семинары)
Урок 6. Одномерные массивы. Продолжение
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("Введите k1"); // Вывод в консоль предложения внести переменную
bool isParsedk1 = double.TryParse(Console.ReadLine(), out double k1); // ввод переменной в консоль с проверкой что введены числа, а не буквы

Console.WriteLine("Введите b1");
bool isParsedk2 = double.TryParse(Console.ReadLine(), out double b1);

Console.WriteLine("Введите k2");
bool isParsedb1 = double.TryParse(Console.ReadLine(), out double k2);

Console.WriteLine("Введите b2");
bool isParsedb2 = double.TryParse(Console.ReadLine(), out double b2);

if (!isParsedk1 || !isParsedk2 || !isParsedb1 || !isParsedb2) // проверяем что во все переменные внесены числа
{
    Console.WriteLine("Ошибка ввода значений"); // если нет вывод в консоль
    return; // прекращение работы программы
}

string str = FindIntersectionPoint(k1, k2, b1, b2); // создание переменной типа string и запись в нее результата выполнения метода 

Console.WriteLine(str); // вывод в консоль


// Метод типа int для определения точек пересечения прямых, либо определения что они параллельны или не пересекаются
string FindIntersectionPoint(double k1, double k2, double b1, double b2)
{
    
    string str = string.Empty; // cоздание переменной типа string и запись в нее пустоты

    double x = 0; // создание переменной типа double и приравнивание ее к 0
    double y = 0; // создание переменной типа double и приравнивание ее к 0

    if (k1 - k2 == 0) // условия проверки что в формуме не возникает деление на 0
    {
        str = $"Ошибка метода - на ноль делить нельзя"; // если возникает вывод в консоль
        return str; // возврат строки как результат выполнения метода
    }
    
    x = -(b1 - b2) / (k1 - k2); // запись в переменную типа double результата формулы
    y = k1 * x + b1; // запись в переменную типа double результата формулы

    str = $"Точка пересечения двух прямых находится в координате [{x}, {y}]"; // при успешном расчете формулы запись в перемунную типа sting
    
    return str; // возврат строки как результат выполнения метода

}
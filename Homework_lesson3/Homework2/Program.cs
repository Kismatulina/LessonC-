/*Знакомство с языками программирования (семинары)
Урок 3. Базовые алгоритмы. Продолжение

Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Введите X1:"); // Вывод в консоль предложения ввести число
int x1 = int.Parse(Console.ReadLine()); // Ввод в консоль числа

Console.WriteLine("Введите Y1:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z1:");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите X2:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Y2:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Z2:");
int z2 = int.Parse(Console.ReadLine());

double result = GetDistance(x1, x2, y1, y2, z1, z2); // создание переменной типа double и запись в нее результата выполнения метода

if (result == 0) // если переменная (рузльтат) равна 0
{
    Console.Write("Переменные введены не правильно"); // если да вывод в консоль
    return; // прекращения работы программы
}

Console.Write("Расстояние между точками: "); //Вывод в консоль
Console.Write(result); // вывод в консоль в ту же строку что и выше

//Метод типа double определения дистанции между точками в 3d пространстве
double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2)
{

    if (x1 == 0 & x2 == 0 & y1 == 0 & y2 == 0 & z1 == 0 & z2 == 0) // если все параметры равны 0
    {
        return 0; // возвращаем 0 и прекращаем выполнение метода
    }

    double L = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)); // создаем переменную типа double и записываем в нее результат формулы

    return L; // возвращаем как рузультат выполнения метода переменную типа double

}

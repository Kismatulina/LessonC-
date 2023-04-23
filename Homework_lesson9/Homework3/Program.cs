/*Знакомство с языками программирования (семинары)
Урок 9. Рекурсия
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29  */

Console.WriteLine("Введите m:");
int m = IsParsedInt();

Console.WriteLine("Введите n:");
int n = IsParsedInt();


Console.WriteLine($"A({m},{n}) = {FindAckermann(m, n)}");


// Рекурсивный метод вычисления функции Аккермана
int FindAckermann(int m, int n)
{
    if (m == 0) { return n + 1; }
    if (m != 0 && n == 0) { return FindAckermann(m - 1, 1); }
    if (m > 0 && n > 0) { return FindAckermann(m - 1, FindAckermann(m, n - 1)); }

    return FindAckermann(m, n);
}


// Рекурсивный метод проверки правильности ввода значения в консоль
int IsParsedInt()
{

    bool status = int.TryParse(Console.ReadLine(), out int a);
    if (status) { return a; }

    if (!status)
    {
        Console.WriteLine("Введено не число, повторите ввод");
    }

    return IsParsedInt();

}
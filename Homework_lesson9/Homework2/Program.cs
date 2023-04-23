/*Знакомство с языками программирования (семинары)
Урок 9. Рекурсия
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */
/*
int number = DataInput();
int DataInput()
{
    Console.WriteLine("Введите первое число");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int sum = SumNumber(number);

Console.WriteLine($"{number} -> {sum}");

int SumNumber(int number)
{
    if (number > 0)
    {
        int sum = number % 10;
        number = number / 10;
        return SumNumber(number) + sum;
    }
    
    return 0;
    
}
*/

Console.WriteLine("Введите начало диапазона:");
bool isParsedStart = int.TryParse(Console.ReadLine(), out int start);

Console.WriteLine("Введите конец диапазона:");
bool isParsedStop = int.TryParse(Console.ReadLine(), out int stop);

if (!isParsedStart || !isParsedStop) { Console.WriteLine("Ошибка ввода, введено не число"); return;}

Print(stop);

void Print(int n)
{
    if (start > stop) { return; }

    Console.WriteLine(start);
    start++;
    
    Print(n);

}
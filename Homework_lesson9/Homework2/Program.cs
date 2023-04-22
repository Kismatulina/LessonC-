/*Знакомство с языками программирования (семинары)
Урок 9. Рекурсия
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30  */
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
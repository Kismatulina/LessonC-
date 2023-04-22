/* Знакомство с языками программирования (семинары)
Урок 9. Рекурсия
Задача 64: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"  */

/*
Print(5);
void Print(int number, int i = 1)
{ 
    if(i<=number)
    {
        //int i = 1;
        Console.WriteLine($"{i}, ");
        Print(number, i+1);
    }
} */
Print(1);
void Print(int number, int i = 5)
{ 
    if(i<=number)
    {
        //int i = 1;
        Console.WriteLine($"{i}, ");
        Print(number, i-1);
    }
}

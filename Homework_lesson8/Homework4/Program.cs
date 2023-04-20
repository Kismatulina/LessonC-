/*Знакомство с языками программирования (семинары)
Урок 8. Двумерные массивы. Продолжение
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine("Введите X:");
bool isParseX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите Y:");
bool isParseY = int.TryParse(Console.ReadLine(), out int y);

Console.WriteLine("Введите Z:");
bool isParseZ = int.TryParse(Console.ReadLine(), out int z);

if (!isParseX || !isParseY || !isParseZ) { Console.WriteLine("Ошибка ввода размености, введено не число"); return; }

int[,,] array3D = Generate3DArray(x, y, z);
Print3DArray(array3D);

// Метод создание трехмерного массива типа int и заполнения его случайными не повторяющимися числами 
int[,,] Generate3DArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    var tmpDictonary = new Dictionary<int, int>();
    Random random = new Random();

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z;)
            {
                int tmp = random.Next(10, 100);

                if (!tmpDictonary.TryAdd(tmp, 1)) { continue; }

                array[i, j, k] = tmp;
                k++;
            } 
        }
    }
    return array;
}


// Метод вывода трехмерного массива в консоль
void Print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"[{i}, {j}, {k}] - {array[i,j,k]}");
            }
        }
    }
}

/* посмотреть после что не так решила:
int[,,] array3 = Generate3DArray(2, 2, 2);// генерируем массив и ввыводим его на экран

//Print3DArray(array3);
//RevesreArray(array);
Console.WriteLine();
//Print3DArray(array3);

int[,,] Generate3DArray(int m, int n, int p) // генерируем массив 
{

    int[,,] array3 = new int[1, 2, 3];
    Random random = new Random();
    for (var i = 0; i < array3.GetLength(0); i++)  //обращение к столбцам
    {
        for (var j = 0; j < array3.GetLength(1); j++)
        {
            for (var k = 0; k < array3.GetLength(2); k++)

            {
                //array3[i, j, k]; здесь просто обратилась по индексам, надо присвоить значение
                //array3[i, j, k] = Random.Next(99,100); // присваиваю значения
                //(Не повторяющихся двузначных чисел необходимо прописать-Можно проверять есть ли это число в массиве,
                //если есть то генерировать новое до тех пор пока не станет уникальным)
                int tmp = random.Next(99,100);
                array3[i, j, k] = tmp;
                k++;
            }
        }
        return array3;
    }

    void Print3DArray(int[,,] array3) //  и ввыводим его на экран
    {
        for (var i = 0; i < array3.GetLength(0); i++)
        {
            for (var j = 0; j < array3.GetLength(1); j++)
            {
                for (var k = 0; k < array3.GetLength(2); k++)

                {
                    //Console.Write(array3[i, j, k]);
                    //Console.Write(" ");
                    Console.WriteLine($"[{i}, {j}, {k}] - {array[i,j,k]}");
                }

                //Console.WriteLine();
            }
        }
    } 
}  */       
    /* не помню от куда, с задачи на уроке, после проверить
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
    /* for (int i = 0; i < array.GetLength(1); i++)//перебераем столбцы
     {
         int tmp = array[0, i];//обращаемся к нашему массиву 0,0 толко теперь к 0,i
         array[0, i] = array[array.GetLength(0) - 1, i];
         array[array.GetLength(0) - 1, i] = tmp;
     } */



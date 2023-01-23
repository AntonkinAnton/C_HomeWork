// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Header(string about)
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains \n");
    Console.WriteLine($"{about}");
}

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    return array;
}


void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1,10);
        }
    }
}

void PrintImage(int[,] array)
{
 System.Console.WriteLine("\nВаш массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
                System.Console.Write(array[i,j]);
                if (j != array.GetLength(1)-1)
                    System.Console.Write(", ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int GetNum(string message)
{
    int num;
    do
    {
        System.Console.WriteLine("\n"+message);
    } while (!int.TryParse(Console.ReadLine(), out num));

    return num;
}

void FindIndexInArray (int [,] array, int row, int col)  // поиск не по индексу!! по номеру строки и столбца
{
    if (row > array.GetLength(0) || col > array.GetLength(1) || row < 1 || col < 1)
    {
        System.Console.WriteLine("\nНет такой позиции!");
    }
    else System.Console.WriteLine($"\nНа позиции ({row}, {col}) находится: {array[row-1, col-1]}");
    System.Console.WriteLine("\n");
}

void AvarageColumns(int[,] matr)
{
    double avrg = 0;

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            avrg += matr[j, i];
        }
        System.Console.WriteLine($"Ср.арифм. по столбцу {i+1} = {avrg/matr.GetLength(0)}");
        avrg = 0;
    }
    System.Console.WriteLine();
}

void SetFontColor(int clr)
{
    switch (clr)
    {

        case 1:
            Console.ForegroundColor = ConsoleColor.Blue;
            break;
        case 2:
            Console.ForegroundColor = ConsoleColor.Cyan;
            break;
        case 3:
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            break;
        case 4:
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            break;
        case 5:
            Console.ForegroundColor = ConsoleColor.DarkGray;
            break;
        case 6:
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            break;
        case 7:
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            break;
        case 8:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            break;
        case 9:
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            break;
        case 10:
            Console.ForegroundColor = ConsoleColor.Gray;
            break;
        case 11:
            Console.ForegroundColor = ConsoleColor.Green;
            break;
        case 12:
            Console.ForegroundColor = ConsoleColor.Magenta;
            break;
        case 13:
            Console.ForegroundColor = ConsoleColor.Red;
            break;
        case 14:
            Console.ForegroundColor = ConsoleColor.White;
            break;
        case 15:
            Console.ForegroundColor = ConsoleColor.Yellow;
            break;

    }
}

async void RunningString(string endmessage, int delayMs)
{
    Console.CursorVisible = false;
    endmessage += " ";
    Random rnd = new Random();

    while (true)
    {
        for (int i = 0; i < endmessage.Length; i++)
        {
            Console.SetCursorPosition(endmessage.Length - 1 - i, Console.CursorTop);
            for (int j = 0; j <= i; j++)
            {
                System.Console.Write(endmessage[j]);
            }

            await Task.Delay(delayMs);

            if (i == endmessage.Length - 1)
            {
                for (int i1 = 0; i1 < endmessage.Length; i1++)
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    for (int j1 = i1 + 1; j1 < endmessage.Length; j1++)
                    {
                        System.Console.Write(endmessage[j1]);
                    }
                    await Task.Delay(delayMs);
                }

                SetFontColor(rnd.Next(1, 16));
            }

        }
    }
}

void End()
{
    Console.ReadKey();
    return;
}



Header("Программа заполняет заданный двумерный массив случайными числами");

int rows = GetNum("Введите кол-во рядов:");

int columns = GetNum("Введите кол-во столбцов:");

int [,] array2d = CreateArray(rows, columns);

FillArray(array2d);

PrintImage(array2d);

AvarageColumns(array2d);

int findRow = GetNum("Введите строку и столбец для поиска. НЕ ИНДЕКС! (стрк, стлб):");

int x = (int)Math.Log10(findRow) + 3;
        Console.SetCursorPosition(x - 2, (Console.CursorTop - 1));
        System.Console.WriteLine(',');
        Console.SetCursorPosition(x, (Console.CursorTop - 1));

int findCol = int.Parse(Console.ReadLine());

FindIndexInArray(array2d, findRow, findCol);

RunningString("Почему проктолога пригласили в IT? Потому что он тоже своего рода разработчик... Нажмите любую клавишу, чтобы выйти... ", 50);

End();
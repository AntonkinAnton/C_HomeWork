
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void Header(string about)
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains \n");
    Console.WriteLine($"{about}");
}

int GetNum(string message)
{
    int num;
    do
    {
        System.Console.WriteLine("\n" + message);
    } while (!int.TryParse(Console.ReadLine(), out num));

    return num;
}

int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];

}

void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 51);
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

            System.Console.Write(array[i, j]);
            if (j != array.GetLength(1) - 1)
                System.Console.Write(", ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ChangeInArray(int[,] array, int raw, int col)
{
    int temp = array[raw, col];
    array[raw, col] = array[raw, col + 1];
    array[raw, col + 1] = temp;
}

List<int> RowSummIn2dArray(int[,] array, int sum = 0)
{
    List<int> sumList = new List<int>();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumList.Add(sum);
        sum = 0;
    }
    return sumList;
}

void FindMinInList(List<int> list, int minIndex = 0)
{
    int minVal = list[0];
    for (int i = 1; i < list.Count; i++)
    {
        if (minVal > list[i]) 
        {
            minVal = list[i];
            minIndex = i;
        }
    }
    System.Console.WriteLine($"Строка {minIndex+1} имеет наименьшую сумму= {minVal}\n");
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



Header("Программа показывают строку массива с наименьшей суммой");

int rows = GetNum("Кол-во рядов:");
int col = GetNum("Кол-во столбцов:");

int[,] array2d = CreateArray(rows, col);
FillArray(array2d);
PrintImage(array2d);

List<int> sumList = RowSummIn2dArray(array2d);

FindMinInList(sumList);

RunningString("Нажмите любую клавишу, чтобы выйти... ", 70);

End();

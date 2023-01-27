// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

void Header(string about)
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains \n");
    Console.WriteLine($"{about}\n");
}

int GetNum(string message)
{
    int num;
    do
    {
        System.Console.WriteLine(message);
    } while (!int.TryParse(Console.ReadLine(), out num));
    System.Console.WriteLine();
    return num;
}

int[,,] CreateArray2x2x2(int x, int y, int z)
{
    return new int[x, y, z];
}

void FillArray(int[,,] matr, List<int> listOfNum)
{
    Random rand = new Random();
    int diffIndex;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                diffIndex = rand.Next(listOfNum.Count);
                matr[i, j, k] = listOfNum[diffIndex];
                listOfNum.RemoveAt(diffIndex);
            }

        }
    }
}

void PrintImage(int[,,] array, string message)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i},{j},{k})");
                if (k != array.GetLength(2) - 1)
                    System.Console.Write(", ");
            }
            System.Console.WriteLine();
        }

    }
    System.Console.WriteLine();
}

List<int> CreateAndFillList(int[,,] array)
{
    List<int> sumList = new List<int>();
    int sizeList = array.GetLength(0)*array.GetLength(1)*array.GetLength(2);
    for (int i = 0; i < sizeList; i++)
    {
        sumList.Add(i);
    }
    return sumList;
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


Header("Программа показывает трехмерный массив, заполненный неповторяющимися числами");

int row = GetNum("Введите кол-во строк:");

int col = GetNum("Введите кол-во столбцов:");

int page = GetNum("Введите кол-во 3rd dimension (pages):");

int[,,] matrix = CreateArray2x2x2(row, col, page);

List<int> sumList = CreateAndFillList(matrix);

FillArray(matrix, sumList);

PrintImage(matrix, "Ваш массив:");

RunningString("Нажмите любую клавишу, чтобы выйти... ", 70);

End();
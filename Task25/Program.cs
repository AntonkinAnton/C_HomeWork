// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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


int[,] CreateArray(int row, int col)
{
    return new int[row, col];

}

void FillArray(int[,] matr)
{
    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(1, 11);
        }
    }
}

void PrintImage(int[,] array, string message)
{
    System.Console.WriteLine(message);
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


void MultiplyArray(int[,] array1, int[,] array2)
{
    int[,] resultArray = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int m = 0; m < resultArray.GetLength(0); m++)
    {
        for (int k = 0; k < resultArray.GetLength(1); k++)
        {
            for (int i = 0; i < array1.GetLength(1) && i < array2.GetLength(0); i++)
            {
                resultArray[m, k] += array1[m, i] * array2[i, k];
            }
        }
    }
    PrintImage(resultArray, "Результат умножения матриц:");

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

Header("Программа умножает две матрицы между собой");

int rows1 = GetNum("Кол-во рядов первой матрицы:");
int col1 = GetNum("Кол-во столбцов первой матрицы:");

int rows2 = GetNum("Кол-во рядов второй матрицы:");
int col2 = GetNum("Кол-во столбцов второй матрицы:");


int[,] matrix1 = CreateArray(rows1,col1);    //{{2, 4},{3,2}}
int[,] matrix2 = CreateArray(rows2,col2);    //{{3, 4},{3,3}}   используйте для проверки решения


FillArray(matrix1);
FillArray(matrix2);

PrintImage(matrix1, "Первая матрица:");
PrintImage(matrix2, "Вторая матрица:");

MultiplyArray(matrix1,matrix2);

RunningString("Нажмите любую клавишу, чтобы выйти... ", 70);

End();

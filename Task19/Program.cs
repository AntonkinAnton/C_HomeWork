// Учитывая целочисленный массив, проверьте, содержит ли он подмассив с нулевой суммой

void Header(string about)
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains \n");
    Console.WriteLine($"{about}\n");
}

int[] CreateArray(int size)
{
    int[] array = new int[size];
    return array;
}

void FillArrayRndmWOnull(int[] array)
{
    Random rnd = new Random();
    int randWOnull = 0;
    for (int i = 0; i < array.Length; i++)
    {
        do
            randWOnull = rnd.Next(-10, 11);
        while (randWOnull == 0);
        array[i] = randWOnull;
    }
}

string ArrayToString(int[] array)
{
    return string.Join(", ", array);
}

void PrintArray(string message, string array1)
{
    System.Console.WriteLine($"\n{message}\n[{array1}]\n");
}

int GetNum(string message)
{
    int num;
    do
    {
        System.Console.WriteLine(message);
    } while (!int.TryParse(Console.ReadLine(), out num));

    return num;
}

void PrintSubarray(int[] array, int i, int j)
{
    System.Console.Write("[");
    for (; i <= j; i++)
    {
        System.Console.Write(array[i]);
        if (i != j) System.Console.Write(", ");
    }
    System.Console.WriteLine("]");
}

void SubarrayNullSum(int[] array)
{
    int sum = 0;
    bool avialibility = false;
    System.Console.WriteLine("Подмассивы равные нулю:");

    for (int i = 0; i < array.Length; i++)
    {
        sum = array[i];
        for (int j = i + 1; j < array.Length; j++)
        {
            sum += array[j];
            if (sum == 0)
            {
                PrintSubarray(array, i, j);
                avialibility = true;
            }
        }
    }
    if (avialibility == false)
        System.Console.WriteLine("Отсутствуют");
    System.Console.WriteLine();
}

void SetFontColor(int clr)

{
    if (clr == 1) Console.ForegroundColor = ConsoleColor.Blue;
    else if (clr == 2) Console.ForegroundColor = ConsoleColor.Cyan;
    else if (clr == 3) Console.ForegroundColor = ConsoleColor.DarkBlue;
    else if (clr == 4) Console.ForegroundColor = ConsoleColor.DarkCyan;
    else if (clr == 5) Console.ForegroundColor = ConsoleColor.DarkGray;
    else if (clr == 6) Console.ForegroundColor = ConsoleColor.DarkGreen;
    else if (clr == 7) Console.ForegroundColor = ConsoleColor.DarkMagenta;
    else if (clr == 8) Console.ForegroundColor = ConsoleColor.DarkRed;
    else if (clr == 9) Console.ForegroundColor = ConsoleColor.DarkYellow;
    else if (clr == 10) Console.ForegroundColor = ConsoleColor.Gray;
    else if (clr == 11) Console.ForegroundColor = ConsoleColor.Green;
    else if (clr == 12) Console.ForegroundColor = ConsoleColor.Magenta;
    else if (clr == 13) Console.ForegroundColor = ConsoleColor.Red;
    else if (clr == 14) Console.ForegroundColor = ConsoleColor.White;
    else if (clr == 15) Console.ForegroundColor = ConsoleColor.Yellow;
}

async void RunningString(string endmessage)
{
    Console.CursorVisible = false;
    Random rnd = new Random();

    for (int i = 0; i < endmessage.Length; i++)
    {
        Console.SetCursorPosition(endmessage.Length - 1 - i, Console.CursorTop);
        for (int j = 0; j <= i; j++)
        {
            System.Console.Write(endmessage[j]);
        }

        await Task.Delay(90);

        if (i == endmessage.Length - 1)
        {
            for (int i1 = 0; i1 < endmessage.Length; i1++)
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                for (int j1 = i1 + 1; j1 < endmessage.Length; j1++)
                {
                    System.Console.Write(endmessage[j1]);
                }
                await Task.Delay(90);
            }
            i = -1;
            SetFontColor(rnd.Next(1, 16));
        }

    }
}

void End()
{
    Console.ReadKey();
    return;
}


Header("Программа показывает подмассивы с нулевой суммой");

int size = GetNum("Введите размер массива:");

int[] array = CreateArray(size);

FillArrayRndmWOnull(array);

PrintArray("Ваш массив:", ArrayToString(array));

SubarrayNullSum(array);

RunningString("Press any key to terminate... ");

End();
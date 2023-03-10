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


Header("Программа показывает подмассивы с нулевой суммой");

int size = GetNum("Введите размер массива:");

int[] array = CreateArray(size);

FillArrayRndmWOnull(array);

PrintArray("Ваш массив:", ArrayToString(array));

SubarrayNullSum(array);

RunningString("Press any key to terminate...", 80);

End();
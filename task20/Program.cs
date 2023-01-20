// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

void Header(string about)
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains \n");
    Console.WriteLine($"{about}\n");
}

string ListToString(List<int> myNum)
{
    return string.Join(", ", myNum);
}

void PrintList(string message, string array1)
{
    System.Console.WriteLine($"\n{message}\n[{array1}]\n");
}

void FillList(List<int> myList, string message)
{
    int num;
    System.Console.WriteLine(message);
    while (int.TryParse(Console.ReadLine(), out num))
    {
        myList.Add(num);
    }

}

void PosNegCount(List<int> myList)
{
    int negCount = 0;
    int posCount = 0;
    int nulls = 0;
    for (int i = 0; i < myList.Count; i++)
    {
        if (myList[i] > 0) posCount++;
        else if (myList[i] < 0) negCount++;
        else if (myList[i] == 0) nulls++;
    }
    System.Console.WriteLine($"Колличество отрицательных чисел: {negCount}");
    System.Console.WriteLine($"Колличество положительных чисел: {posCount}");
    System.Console.WriteLine($"Колличество нулей: {nulls}\n\n\n");
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


Header("Программа показывает сколько Вы ввели отрицательных и положительных чисел");

List<int> myList = new List<int>();

FillList(myList, "Введите числа. По окончанию нажмите Enter, либо введите не цифры:");

string List = ListToString(myList);

PrintList("Вы ввели:", List);

PosNegCount(myList);

RunningString("Нажмите любую клавишу, чтобы выйти...", 70);

End();
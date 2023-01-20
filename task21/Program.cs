// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Header(string about)
{
    Console.Clear();
    Console.WriteLine("Антонкин Антон | Группа Разработчик 3776 | GeekBrains \n");
    Console.WriteLine($"{about}");
}

double GetNum(string message)
{
    double num;
    do
    {
        System.Console.Write(message + " ");
    } while (!double.TryParse(Console.ReadLine(), out num));

    return num;
}

(double k, double b) GetStraight(string message)

{
    System.Console.WriteLine("\n" + message + "\n");


    double k = GetNum("k:");
    double b = GetNum("b:");
    return (k, b);
}

void PointOfCross((double k, double b) point1, (double k, double b) point2)
{
    double x = (point1.b - point2.b) / (point2.k - point1.k);
    double y = point1.k * x + point1.b;

    if (point1.k == point2.k)
    {
        if (point1.b == -point2.b)
            System.Console.WriteLine("\nПрямые параллельны");
        else if (point1.b == point2.b)
            System.Console.WriteLine("\nПрямые лежат на одной линии");
    }
    else
        System.Console.WriteLine($"\nТочка пересечения прямых: ({x}; {y})");

    System.Console.WriteLine("\n\n");
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



Header("Программа показывает точку пересечения двух прямых");

(double k, double b) Line1 = GetStraight("Введите точки первой прямой:");

(double k, double b) Line2 = GetStraight("Введите точки второй прямой:");

PointOfCross(Line1, Line2);

RunningString("Нажмите любую клавишу, чтобы выйти...", 70);

End();


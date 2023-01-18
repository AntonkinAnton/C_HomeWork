// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// за нечетные позиции в данном случае приняли, видимо, нечетные индексы.

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

void FillArrayRndm(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10);
    }
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

void SumOddPositionOfArray(int[] array)
{
    int count = 0;
    System.Console.Write("\nВаш массив: \n[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            count += array[i];
        }
        System.Console.Write(array[i]);
        Console.ResetColor();
        if (i!=array.Length-1) 
             System.Console.Write(", ");
    }
    System.Console.Write("]\n");
    System.Console.WriteLine($"\nСумма нечетных позиций в массиве:\n{count}\n");
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

async void EndMessage(string endmessage)
{
    Console.CursorVisible = false;
    Random rnd = new Random();

    for (int i = 0; i < endmessage.Length; i++)
    {
        
        Console.SetCursorPosition(i, Console.CursorTop);
        System.Console.Write(endmessage[i]);
        await Task.Delay(10);
        if ((i+1) % (endmessage.Length) == 0) 
        {
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


Header("Программа показывает сумму нечетных индексов массива случайных чисел");

int size = GetNum("Введите размер массива:");

int[] array = CreateArray(size);

FillArrayRndm(array);

SumOddPositionOfArray(array);

EndMessage("Press any key to terminate...");

End();





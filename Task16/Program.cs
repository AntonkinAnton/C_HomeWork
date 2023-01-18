// Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        array[i] = rnd.Next(100, 1000);
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

void QuantityEvenNum(int[] array)
{
    int count = 0;
    System.Console.Write("\nВаш массив: \n[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            count++;
        }
        System.Console.Write(array[i]);
        Console.ResetColor();
        if (i!=array.Length-1) 
             System.Console.Write(", ");
        
    }
    System.Console.Write("]\n");
    System.Console.WriteLine($"\nКоличество четных чисел в массиве:\n{count}\n");
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
    System.Console.WriteLine(endmessage);
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    Random rnd = new Random();
    int iRand;
    while (true)
    {
        iRand = rnd.Next(endmessage.Length);
        SetFontColor(rnd.Next(1, 16));
        Console.SetCursorPosition(iRand, Console.CursorTop);
        System.Console.Write(endmessage[iRand]);
        await Task.Delay(30);
    }

}

void End()
{
    Console.ReadKey();
    return;
}

Header("Программа создает массив из трехзначных чисел и считает сколько четных из них");

int size = GetNum("Введите размер массива:");

int[] array = CreateArray(size);

FillArrayRndm(array);

QuantityEvenNum(array);

EndMessage("Press any key to terminate...");

End();
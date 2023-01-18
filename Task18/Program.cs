// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

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
        array[i] = rnd.Next(-15,16);
    }
}

void PrintMinMaxArray(int[] array, int min, int max)
{
    System.Console.Write("\nВаш массив: \n[");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == min)
            SetFontColor(8);
        else if (array[i] == max)
            SetFontColor(2);

        System.Console.Write(array[i]);
        Console.ResetColor();
        if (i!=array.Length-1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]\n");
    System.Console.WriteLine($"min = {min}\nmax = {max}\nРазница = {max-min}\n");
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

void DiffBetweenMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) 
            min = array[i];
        
        else if (array[i] > max) 
            max = array[i];
           
    }
    PrintMinMaxArray(array, min, max);

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

    for (int i = endmessage.Length / 2, j = endmessage.Length / 2; i < endmessage.Length; i++, j--)
    {

        Console.SetCursorPosition(i, Console.CursorTop);
        System.Console.Write(endmessage[i]);
        Console.SetCursorPosition(j, Console.CursorTop);
        System.Console.Write(endmessage[j]);
        await Task.Delay(40);
        if (i % (endmessage.Length - 1) == 0 || j % (endmessage.Length - 1) == 0)
        {
            i = endmessage.Length / 2 - 1;
            j = endmessage.Length / 2 + 1;
            SetFontColor(rnd.Next(1, 16));
        }

    }


}

void End()
{
    Console.ReadKey();
    return;
}


Header("Программа показывает разницу между max и min значениями массива");

int size = GetNum("Введите размер массива:");

int[] array = CreateArray(size);

FillArrayRndm(array);

DiffBetweenMinMax(array);

EndMessage("Press any key to terminate...");

End();




